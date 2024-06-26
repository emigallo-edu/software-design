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

### Formato

El formateo de código trata sobre la comunicación y la comunicación es de primer orden para los desarrolladores profesionales.

Un código es una jerarquía. Hay información que pertenece al archivo como un todo, a las clases individuales dentro del archivo, a los métodos dentro de las clases, a los bloques dentro de los métodos, y de forma recursiva a los bloques dentro de los bloques. Cada nivel de esta jerarquía es un ámbito en el que los nombres pueden ser declarados y en la que las declaraciones y sentencias ejecutables se interpretan. Para hacer esta jerarquía visible, hay que sangrar la líneas de código fuente de forma proporcional a su posición en la jerarquía.

Utilizamos el espacio en blanco horizontal para asociar las cosas que están fuertemente relacionadas y disociar las cosas que están más débilmente relacionadas y para acentuar la precedencia de operadores.

- Los atributos deben declararse al principio de la clase
- Las funciones dependientes en que una llama a otra, deberían estar verticalmente cerca: primero la llamante y luego la llamada
- Grupos de funciones que realizan operaciones parecidas, deberían permanencer juntas
- Las variables deberían declararse tan cerca comos sea posible de su utilización, minimizar el intervalo de vida de una variable
- Los programadores prefieren líneas cortas (~40, máximo80/120)


### Estándares

Seguir las convencion estándar.

Según la tecnología:
    
Java
- Los métodos empiezan con minúscula
- Los desplegables (package) empiezan con minúscula
- Los atributos privados de una clase empiezan con minúscula

JavaScript
- Los métodos empiezan con minúscula
- Los atributos privados de una clase empiezan con minúscula

C#
- Los métodos empiezan con mayúscula
- Los desplegables (assembly) empiezan con mayúscula
- Los atributos privados de una clase empiezan con '_' + minúscula

Según proyecto:
- Métodos de máximo 10 lineas de código
- Clases de máximo 100 líneas de código
- Prohibir el uso de 'var' para declarar una varible: var customer = new Customer();

### Consistencia

Si haces algo de cierta manera, haz todas las cosas similares de la misma forma.
Si dentro de una función se utiliza una variable "interval", a continuación, utilizar el mismo nombre de variable en las otras funciones que utilizan variables "interval".
Si se nombra un método "processVerificationRequest", a continuación, utiliza un nombre similar, como "processDeletionRequest", para los métodos que procesan otros tipos de solicitudes.


### Software mínimo

#### Código muerto

Son fragmentos de código (variables, métodos, clases) que no estan siendo usados.
Si no se elimina el código muerto, puede continuar proliferando según se reutiliza código en otras áreas.
Bloques de código comentado sin explicación o documentación.

#### DRY (Don’t Repeat Yourself)

Evitar re-analizar, re-diseñar, re-codificar, re-probar y re-documentar soluciones que complican enormemente el mantenimiento correctivo, perfectivo y adaptativo.
Cada pieza de conocimiento debe tener una única e inequívoca representación en un sistema.
El objetivo es reducir la repetición de la información de todo tipo, lo que hace que los sistemas de software sean más fácil de mantener.
La consecuenciaes que una modificación de cualquier elemento individual de un sistema no requiere un cambio en otros elementos lógicamente no relacionados.

Aplicable a todo: la programación, esquemas de bases de datos, planes de prueba, el sistema de construcción, análisis y diseños, incluso la documentación.

#### YAGNI (You aren’t going to need it)

Siempre se implementan cosas cuando realmente se necesitan, no cuando se prevén que se necesiten. Por tanto, no se debe agregar funcionalidad hasta que se considere estrictamente necesario.

Hasta que la característica es realmente necesaria, es difícil definir completamente lo que debe hacer y probarla. Si la nueva característica no está bien definida y probada, puede que no funcione correctamente, incluso si eventualmente se necesitara.

Cualquier nueva característica impone restricciones en lo que se puede hacer en el futuro, por lo que una característica innecesaria puede interrumpir características necesarias que se agreguen en el futuro.

Conduce a la hinchazón de código y el software se hace más grande y más complicado. Añadir nuevas características puede sugerir otras nuevas características. Si estas nuevas funciones se implementan así, esto podría resultar en un efecto bola de nieve.
