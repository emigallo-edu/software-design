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