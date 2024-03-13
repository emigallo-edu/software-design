# Código limpio

- [Nombrado](#nombrado)
- [Legibilidad](#legibilidad)
- [Funciones](#funciones)

## Nombrado

> Si el nombre requiere un comentario, entonces el nombre no revela su intensión.  — Robert C. Martin

Los nombres deben revelar su intención. Deberían revelar por qué existe, qué hace, y cómo se utiliza para facilitar la legibilidad para el desarrollo y el mantenimiento correctivo, perfectivo y adaptativo.
La elección de buenos nombres lleva tiempo, pero ahorra más de lo que toma. Así que ten cuidado con los nombres y cámbialos cuando encuentres otros mejores.

#### Elige nombres descriptivos. Nombres del dominio

    public Customer Customer { get; set; }
    public Customer Client { get; set; }
    public Customer Cus { get; set; }

#### Elige nombres al nivel de abstracción apropiado

    namespace Bromus.Apex.Production.StockBatches.Commands
    {
        public class PushStockBatchDetailsCommandHandler
        {
            private StockBatchesQueryRepository _stockBatchesQueryRepository;
            
            public void PushStockBatch(StockBatch item)
            {
                if(item.IsNew())
                {
                    this._stockBatchesQueryRepository.InsertStockBatch(item);
                }
                else
                {
                    this._stockBatchesQueryRepository.UpdateStockBatch(item);
                }
            }
        }
    }
    
<br>

    namespace Bromus.Apex.Production.StockBatches.Data
    {
        public class StockBatchesQueryRepository
        {
            public void UpdateStockBatch(StockBatch item)
            {

            }

            public void InsertStockBatch(StockBatch item)
            {

            }
        }
    }

#### Usa nomenclatura estándar donde sea posible

En C# métodos empiezan con mayúscula
En JS y Java empiezan con minúscula

#### Usa nombre no ambiguos

    private Student _sutendData;
    private string _message;

#### Los nombre deberían describir los efectos laterales

    public void ResetPassword(User user)
    {
        user.Password = "";
    }

    public void MarkToDeliverToday(Order order)
    {
        order.DeliveryDate = Date.Today;
    }

#### Elegir una palabra para un concepto

    public class PlanificationRepository
    {
        public void Update(Planification item)
        {

        }
    }

<br>

    public class ProductionRepository
    {
        public void Change(Production item)
        {

        }
    }

<br>

    public class StockBatchRepository
    {
        public void Modify(StockBatch item)
        {

        }
    }

#### Los nombres de paquetes deben ser sustantivos

- Apex.Safety
- Apex.Production

#### Los nombres de las clases deben ser suntativos

    public class Customer
    {

    }

    public class Stock
    {

    }   
    
    public class Product
    {

    }

#### Nombres de métodos deben comenzar con verbos. Deben expresar lo que hacen

    public class CalculateDebt()
    {

    }

    public class DeleteCustomer()
    {

    }


#### Evita prefijos

    public void GetAccount(Customer pCustomer)
    {
    }

<br>

    private string _stringDesc;
    

## Legibilidad

### Comentarios

> El uso de los comentarios es un fallo para compensar nuestra incapacidad de expresarnos en código. Tener en cuenta que utilicé la palabra *fallo*. Los comentarios siempre son *fallos*. Debemos tenerlos porque no siempre sabemos cómo expresarnos sin ellos, pero su uso no es motivo de celebración. - Robert C. Martin

> Entonces, cuando te encuentres en una posición en la que necesites escribir un comentario, piénsalo detenidamente y ve si no hay alguna manera de modificarlo y expresarte en código. Cada vez que te expresas en código, debes darte una palmadita en la espalda. Cada vez que escribes un comentario, debes hacer una mueca y sentir la falta de tu capacidad de expresión. - Robert C. Martin

#### Explicarse en código

    // Chequea si el empleado is aplicable para los beneficios completos
    if ((employee.flags && HOURLY_FLAG) 
            && employee.age > 65)

<br>

    if(employee.isElegibleForFullBenefits())

#### Comentarios legales

    // Copyright (C) 2003 by Object Mentor, Inc. All rights reserved.

<br>

    // Released under the terms of the GNU General Public License version 2 or later.

#### Comentarios informativos

    // Returns an instances of the Responder being tested.
    protected abstract Responder responderInstance();

<br>

    protected abstract Responder responderBeingTested();

#### Amplificación

    public bool ContainsName(List<Customer> list, string customerName)
    {
        // The trim and upper case are real importat. Both make the item to be found in the list.
        return list.Any(x => x.Name == customerName.Trim().ToUpperCase());
    }

<br>

    public bool ContainsName(List<Customer> list, string customerName)
    {
        return list.Any(x => x.Name == this.PrepareCustomerNameForSearch(customerName));
    }

    private string PrepareCustomerNameForSearch(string customerName)
    {
        return customerName.Trim()
            .ToUpperCase();
    }

#### API's públicas

No hay nada tan útil y satisfactorio como una API pública bien descrita. Los javadocs para la biblioteca estándar de Java son un ejemplo de ello. Sería difícil, en el mejor de los casos, escribir programas Java sin ellos.

Si se escribe una API pública, entonces se debería escribir buenos *javadocs* para ella. Pero tenga en cuenta el resto de los consejos de este capítulo. Los Javadocs pueden ser engañosos como cualquier otro tipo de comentario.

#### Usa una función para reemplazar un comentario

    public async Task<CloseCustomerOrdersResult> ExecuteAsync(CloseCustomerOrdersParameters pParameters)
    {
        CloseCustomerOrdersResult mResult = new CloseCustomerOrdersResult();

        try
        {
            //
            ...
            //

            // Cierre de ProductOrder
            List<ProductOrder> mProductOrders = await _ProductOrdersService.GetQueryRepository()
                .GetProductOrdersByCustomerOrderId(mCustomerOrder.Id);

            mProductOrders = mProductOrders.Where(x => x.IsActive()).ToList();

            foreach (ProductOrder mProductOrder in mProductOrders)
            {
                _Logger.LogInformation($"Cerrando PRODUCT_ORDER {mProductOrder.Number}");

                await _ProductOrdersService.CloseProductOrder(mProductOrder, msg);

                _Logger.LogInformation($"Cerrada PRODUCT_ORDER {mProductOrder.Number}");
            }


            // Cierre de ProductDispatchOrders
            List<ProductDispatchOrder> mProductDispatchOrders = await _ProductDispatchOrdersService
                .GetContext().ProductDispatchOrders.AsNoTracking()
                .Where(x => x.CustomerOrderId == mCustomerOrder.Id)     
                .ToListAsync();

            foreach (ProductDispatchOrder order in mProductDispatchOrders)
            { 
                _Logger.LogInformation($"Cerrando PRODUCT_DISPATCH_ORDER {order.Number}");

                var parameters = new CloseProductDispatchOrdersParameters();

                parameters.ProductDispatchOrderId = order.ToString();

                await _CloseProductDispatchOrdersExecutor.ExecuteAsync(parameters);

                _Logger.LogInformation($"Cerrada PRODUCT_DISPATCH_ORDER {order.Number}");
            }


        }
        catch (Exception e)
        {
            mResult.SetError(e);

            _Logger.LogError(mResult.ReturnMessage);
        }

        return mResult;
    }

<br>

    public async Task<CloseCustomerOrdersResult> ExecuteAsync(CloseCustomerOrdersParameters pParameters)
    {
        CloseCustomerOrdersResult mResult = new CloseCustomerOrdersResult();

        try
        {
            //
            ...
            //

            this.CloseProductOrder();
            this.CloseProductDispatchOrders();
        }
        catch (Exception e)
        {
            mResult.SetError(e);

            _Logger.LogError(mResult.ReturnMessage);
        }

        return mResult;
    }

    private void CloseProductOrder()
    {
        List<ProductOrder> mProductOrders = await _ProductOrdersService.GetQueryRepository()
            .GetProductOrdersByCustomerOrderId(mCustomerOrder.Id);

        mProductOrders = mProductOrders.Where(x => x.IsActive()).ToList();

        foreach (ProductOrder mProductOrder in mProductOrders)
        {
            _Logger.LogInformation($"Cerrando PRODUCT_ORDER {mProductOrder.Number}");

            await _ProductOrdersService.CloseProductOrder(mProductOrder, msg);

            _Logger.LogInformation($"Cerrada PRODUCT_ORDER {mProductOrder.Number}");
        }
    }

    private void CloseProductDispatchOrders()
    {
        List<ProductDispatchOrder> mProductDispatchOrders = await _ProductDispatchOrdersService
                .GetContext().ProductDispatchOrders.AsNoTracking()
                .Where(x => x.CustomerOrderId == mCustomerOrder.Id)     
                .ToListAsync();

        foreach (ProductDispatchOrder order in mProductDispatchOrders)
        { 
            _Logger.LogInformation($"Cerrando PRODUCT_DISPATCH_ORDER {order.Number}");

            var parameters = new CloseProductDispatchOrdersParameters();

            parameters.ProductDispatchOrderId = order.ToString();

            await _CloseProductDispatchOrdersExecutor.ExecuteAsync(parameters);

            _Logger.LogInformation($"Cerrada PRODUCT_DISPATCH_ORDER {order.Number}");
        }
    }

#### Código comentado

    mCustomerOrder.Status = CustomerOrderStates.Cerrada;
    // mCustomerOrder.StatusDate = DateTimeUtils.GetCurrentDateTime();
    mCustomerOrder.StatusReason = pParameters.StatusReason;

#### Formato
#### Estándares
#### Software mínimo


## Funciones

#### Tamaño
#### Haz una cosa
#### Argumentos
#### Efecto lateral
#### Arrojar Excepciones en lugar de código de error


https://www.amazon.com/Clean-Code-Handbook-Software-Craftsmanship/dp/0132350882