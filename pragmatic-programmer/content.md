> Es un proceso continuo
Un turista que visitaba el Eton College en Inglaterra preguntó al jardinero cómo lograba que el
césped fuese tan perfecto.
—Es fácil. Solo hay que retirar el rocío todas las mañanas, cortar cada dos días y pasar el rodillo
una vez a la semana —respondió el jardinero.
—¿Eso es todo? —preguntó el turista.
—Desde luego —respondió el jardinero—. Hágalo durante 500 años y también tendrá un césped
así de bonito.
Los buenos céspedes necesitan pequeñas cantidades de cuidados diarios,
y lo mismo ocurre con los buenos programadores. A los consultores de
gestión les gusta meter la palabra kaizen en las conversaciones. “Kaizen” es
un término japonés que captura el concepto de hacer muchas mejoras
pequeñas de manera continua. Se consideró que fue una de las principales
razones para la espectacular ganancia en productividad y calidad en la
fabricación japonesa y se copió por todo el mundo. El kaizen se aplica
también a los individuos. Trabaje cada día para perfeccionar sus habilidades
y para añadir nuevas herramientas a su repertorio. A diferencia del césped
de Eton, empezará a ver resultados en cuestión de días. Con los años, le
impresionará ver cuánto ha florecido su experiencia y cuánto han crecido
sus habilidades. pagina 29

> En el centro de las ciudades, algunos edificios son bonitos y están
limpios, mientras que otros son armatostes deteriorados. ¿Por qué? Los
investigadores en el campo del crimen y el deterioro urbano descubrieron
un mecanismo desencadenante fascinante, uno que convierte con rapidez un
edificio limpio, intacto y habitado en uno ruinoso y abandonado.3
Una ventana rota.
Una ventana rota que se deje sin reparar durante un periodo de tiempo
considerable infunde en los habitantes del edificio una sensación de
abandono, una sensación de que a los responsables no les importa el
edificio. Así que se rompe otra ventana. La gente empieza a tirar basura.
Aparecen grafitis. Comienza a producirse un daño estructural serio. En un
periodo de tiempo relativamente corto, el edificio queda demasiado dañado
para que el propietario quiera arreglarlo, y la sensación de abandono se
convierte en una realidad.
¿Qué marcaría una diferencia? Varios psicólogos han realizado estudios4
que demuestran que la desesperanza puede ser contagiosa. Piense en el
virus de la gripe en espacios cerrados. Ignorar una situación que está claro
que va mal refuerza la idea de que quizá nada puede arreglarse, que no le
importa a nadie, que todo está abocado al fracaso; son todo pensamientos
negativos que se extienden por los miembros del equipo, lo que genera un
círculo vicioso. pagina 36

> Pensamiento crítico
La última cuestión importante es pensar de manera crítica en lo que lee y
escucha. Tiene que asegurarse de que los conocimientos que guarda en su
cartera son exactos y no están influidos por el bombo que les dan los
distribuidores o los medios. Tenga cuidado con los fanáticos que insisten en
que su dogma proporciona la única respuesta; puede ser o no ser aplicable a
usted y a su proyecto. Nunca subestime el poder del comercio. Que un
motor de búsqueda en la web muestre primero un resultado no significa que
sea el más adecuado; el proveedor de contenido puede pagar para aparecer
en lo más alto. Que una librería coloque un libro en un lugar prominente no
quiere decir que sea un buen libro, ni siquiera popular; pueden haber
pagado para que se ponga ahí.pagina 50

> Un diseño bueno es más fácil de cambiar que un diseño malo.
Una. 
Una cosa está bien diseñada si se adapta a las personas que la utilizan.
Para el código, eso significa que debe adaptarse cambiando, así que
creemos en el principio ETC: Easier to Change, más fácil de cambiar. ETC.
Eso es todo. Por lo que sabemos, cualquier principio de diseño que existe es
un caso especial del ETC.
¿Por qué es bueno el desacoplamiento? Porque al aislar los intereses
hacemos que sea más fácil cambiar. ETC.
¿Por qué es útil el principio de responsabilidad única? Porque un cambio
en los requisitos se corresponde con un cambio en un solo módulo. ETC.

¿Por qué es importante el momento de poner nombres? Porque los
buenos nombres hacen que el código sea más fácil de leer, y hay que leerlo
para cambiarlo. ¡ETC! pagina 61



> Como programadores, recopilamos, organizamos, mantenemos y
aprovechamos conocimientos. Documentamos el conocimiento en
especificaciones, le damos vida en código en ejecución y lo utilizamos para
ofrecer las comprobaciones necesarias durante las pruebas.
Nos parece que la única manera de desarrollar software de manera
fiable, y de hacer que nuestros desarrollos sean más fáciles de entender y
mantener, es seguir lo que llamamos principio DRY.
Cualquier porción de información debe tener una representación única,
inequívoca y autoritativa dentro de un sistema.
La alternativa es tener la misma cosa expresada en dos o más lugares. Si
cambia una, tiene que recordar cambiar las otras o, como ocurría con los
ordenadores alienígenas, el programa acabará derrotado por una
contradicción. No es una cuestión de si se acordará: es una cuestión de
cuándo se le olvidará.
DRY tiene que ver con la duplicación de la información, del propósito.
Tiene que ver con expresar la misma cosa en dos lugares diferentes,
posiblemente de dos maneras distintas por completo.
Y aquí viene la prueba de fuego: cuando tiene que cambiar un solo
aspecto del código, ¿se descubre a sí mismo teniendo que hacer ese cambio
en múltiples lugares y en múltiples formatos diferentes? ¿Tiene que cambiar
el código y la documentación, o un esquema de base de datos y una
estructura que lo alberga, o...? Si es así, su código no es DRY. Así pues,
vamos a ver algunos ejemplos típicos de duplicación. pagina 64


> No todas las duplicaciones de código son duplicaciones de
información










> Puede que necesite preguntar al usuario que ha informado del fallo
para recopilar más datos de los que se le han dado al principio.
■ Las pruebas artificiales (como la única pincelada del programador de
la parte superior a la inferior) no comprueban lo suficiente de la
aplicación. Debe poner a prueba de forma brutal condiciones de
contorno y patrones de uso realistas de los usuarios finales. Debe
hacerlo de manera sistemática (consulte “Pruebas despiadadas y
continuas” en el tema 51). pagina 138

> Hay que fallar la prueba antes de arreglar el código. pagina 139

> Consideramos que, a menudo, ayuda tener un boli y un papel a mano
para poder tomar notas. En particular, muchas veces nos topamos con una
pista y la seguimos solo para descubrir que no lleva a ninguna parte. Si no
anotásemos dónde estábamos cuando empezamos a seguir la pista,
podríamos perder mucho tiempo volviendo a ese punt opagina 130


> La búsqueda binaria
Todo graduado en ciencias de la computación se ha visto obligado a
escribir código para una búsqueda binaria. La idea es simple. Estamos
buscando un valor concreto en una matriz ordenada. Podríamos mirar cada
valor uno a uno, pero acabaríamos mirando más o menos la mitad de las
entradas por término medio hasta que encontrásemos el valor que
queríamos o encontrásemos un valor mayor que él, lo que querría decir que
el valor no está en la matriz. Pero es más útil utilizar el enfoque “divide y
vencerás”. Elija un valor en la parte media de la matriz. Si es el valor que
estaba buscando, pare. Si no, puede partir la matriz en dos. Si el valor que
encuentra es mayor que el valor objetivo, entonces sabe que este debe estar
en la primera mitad de la matriz y, de lo contrario, está en la segunda.
Repita el procedimiento en la submatriz que corresponda y enseguida
tendrá un resultado. (Como veremos en “Notación Big O”, en el tema 39,
una búsqueda lineal es O(n), y una búsqueda binaria es O(logn)).
Así pues, la búsqueda binaria es mucho mucho más rápida en cualquier
problema de un tamaño decente. Vamos a ver cómo aplicarla a la
depuración.
Cuando se enfrente a un seguimiento de pila masivo y esté intentando
averiguar exactamente qué función manipuló el valor en el error, puede
hacer una búsqueda eligiendo un marco de pila en algún punto hacia la
mitad y viendo si el error se manifiesta ahí. Si lo hace, entonces sabrá que
hay que concentrarse en los marcos anteriores; si no, será en los siguientes.
Si su equipo ha introducido un fallo durante un conjunto de liberaciones,
puede emplear el mismo tipo de técnica. Cree una prueba que haga fallar la
liberación actual. A continuación, escoja una liberación en un punto
intermedio entre el presente y la última versión que se sabe que funcionaba.
Ejecute la prueba de nuevo y determine cómo afinar la búsqueda. Ser capaz
de hacer esto es solo uno de los múltiples beneficios de contar con un buen
control de versiones en sus proyectos. De hecho, muchos sistemas de
control de versiones van más allá y automatizan el proceso, seleccionando
liberaciones por nosotros en función del resultado de la prueba pagina 141


> Patito de goma
Una técnica muy sencilla, pero muy útil, para encontrar la causa de un
problema es simplemente explicárselo a otros. La otra persona debería
mirar la pantalla por encima de nuestro hombro y asentir todo el tiempo
(como un patito de goma que se balancea arriba y abajo en la bañera). No
hace falta que digan nada; el simple acto de explicar, paso a paso, lo que se
supone que hace el código consigue a menudo que el problema salga de la
pantalla y se presente solo ante nosotros.3
Suena muy simple, pero, al explicar el problema a otra persona, tenemos
que decir de manera explícita cosas que quizá daríamos por sentadas al
avanzar por el código nosotros solos. Cuando tenemos que verbalizar
algunos de estos supuestos, de pronto conseguimos una nueva visión del
problema. Y, si no hay otra persona cerca, un patito de goma, un osito de
peluche o una planta en una maceta servirán pagina 143




Parece que hay un mantra que todo programador debe memorizar al
principio de su carrera. Es un dogma fundamental de la informática, una
creencia fundamental que aprendemos a aplicar a los requisitos, los diseños,
el código, los comentarios, casi todo lo que hacemos. Dice:
Esto nunca puede pasar...
“Esta aplicación nunca se usará en el extranjero, así que ¿por qué
internacionalizarla?”, “count no puede ser negativo”, “el inicio de sesión
no puede fallar”.
No practiquemos esta clase de autoengaño, sobre todo cuando
escribamos código.
Truco 39. Use aserciones para evitar lo imposible.
Cada vez que se descubra pensando: “Pero, por supuesto, eso nunca
podría ocurrir”, añada código para comprobarlo. La manera más fácil de
hacerlo es utilizar aserciones. En muchas implementaciones de lenguajes,
encontrará alguna forma de assert que comprueba una condición
booleana.2 Estas comprobaciones pueden ser muy valiosas. Si un parámetro
o un resultado nunca debería ser null, compruébelo de manera explícita:
assert (result != null); pagina 166

Pensar en el código como una serie de transformaciones (anidadas)
puede ser un enfoque liberador a la hora de programar. Lleva un tiempo
acostumbrarse a ello, pero, una vez que desarrolle el hábito, verá que su
código se vuelve más limpio, sus funciones más cortas y sus diseños más
planos. pagina 218

La sabiduría popular dice que, una vez que un proyecto está en la fase de
escritura del código, el trabajo es sobre todo mecánico, para transcribir el
diseño como sentencias ejecutables. Nosotros creemos que esta actitud es la
principal razón por la que fracasan los proyectos de software y muchos
sistemas acaban siendo feos, ineficientes, con una estructura pobre,
imposibles de mantener o, simplemente, que están mal.
La escritura del código no es mecánica. Si lo fuese, las herramientas
CASE en las que la gente depositó sus esperanzas a principios de los
ochenta habrían reemplazado a los programadores hace mucho tiempo. Hay
que tomar decisiones a cada minuto, decisiones que requieren una reflexión,
cuidados y un buen criterio si se quiere que el programa resultante disfrute
de una vida larga, productiva y precisa. 

Los desarrolladores que no piensan de forma activa en
su código están programando por casualidad; quizá el código funcione, pero
no hay ninguna razón en particular para que lo hag
pagina 264


A veces, el código vuela desde el cerebro al editor: las ideas se
convierten en bits sin esfuerzo aparente.
Otros días, parece que el código va subiendo por una colina llena de
barro. Cada paso requiere un esfuerzo tremendo y cada tres pasos
retrocedemos dos. Pero, como es profesional, no afloja, sigue dando paso
tras paso en el barro: tiene un trabajo que hacer. Por desgracia, es probable
que eso sea justo lo contrario de lo que debería hacer.
Su código está intentando decirle algo. Le está diciendo que esto es más
difícil de lo que debería ser. Quizá la estructura o el diseño estén mal, tal
vez está resolviendo el problema equivocado o puede que esté creando un
millón de fallos. Sea cual sea el motivo, su cerebro reptiliano está sintiendo
el feedback que envía el código y está intentando desesperadamente que lo
escuche. pagina 266

Programar por casualidad
¿Alguna vez ve viejas películas bélicas en blanco y negro? El soldado
agotado sale con cautela de la maleza. Hay un claro ante él: ¿está lleno de
minas o es seguro cruzarlo? No hay nada que indique que es un campo de
minas; no hay señales, ni alambradas ni cráteres. El soldado toca el suelo
delante de él con su bayoneta y se encoge, esperando una explosión. No hay
ninguna. Así que sigue avanzando con cuidado por el campo durante un
rato, tocando y pinchando a medida que se mueve. Al final, convencido de
que el terreno es seguro, se yergue y camina hacia delante con orgullo, hasta
que vuela en pedazos.
El sondeo inicial del soldado en busca de minas no había revelado nada,
pero había sido solo suerte. Había llegado a una conclusión falsa, con
consecuencias desastrosas.
Como desarrolladores, también trabajamos en campos de minas. Hay
cientos de trampas esperando para pillarnos cada día. Recordando la
historia del soldado, deberíamos ser cautos a la hora de sacar falsas
conclusiones. Deberíamos evitar programar por casualidad (depender de la
suerte y los éxitos accidentales) y, en vez de eso, programar de forma
deliberada. pagina 271


Es fácil dejarse engañar por esta línea de pensamiento. ¿Por qué
deberíamos correr el riesgo de enredar con algo que está funcionando?
Bueno, se nos ocurren varias razones:
■ Puede que en realidad no esté funcionado; tal vez solo lo parezca.
■ La condición de contorno de la que dependemos puede ser solo un
accidente. En circunstancias diferentes (una resolución de pantalla
diferente, más núcleos de CPU), podría comportarse de manera
distinta.
■ Un comportamiento no documentado puede cambiar con el siguiente
lanzamiento de biblioteca.
■ Las llamadas adicionales e innecesarias ralentizan el código.
■ Las llamadas adicionales incrementan el riesgo de introducir nuevos
fallos propios. pagina 273


A medida que evoluciona un programa, va haciéndose necesario
replantearse decisiones anteriores y reelaborar porciones del código. Este
proceso es perfectamente natural. El código necesita evolucionar; no es una
cosa estática
Martin Fowler define la refactorización en Refactoring [Fow19] como
una:
técnica disciplinada para reestructurar un cuerpo de código existente, alterando su estructura
interna sin cambiar su comportamiento externo.

Refactorizamos cuando hemos aprendido algo; cuando entendemos algo
mejor de lo que lo hacíamos el año pasado, ayer o hace solo unos minutos.
Quizá se haya encontrado con un obstáculo porque el código ya no
encaja del todo, o se da cuenta de que hay dos cosas que, en realidad,
deberían estar fusionadas, o cualquier otra cosa que le dé la sensación de
estar “mal”; no dude en cambiarlo. No deje para mañana lo que pueda hacer
hoy. Hay varias cosas que pueden hacer que un código sea un buen
candidato a la refactorización:
■ Duplicación: Ha descubierto una violación del principio DRY.
■ Diseño no ortogonal: Ha descubierto algo que podría hacerse más
ortogonal.
■ Información desfasada: Las cosas cambian, los requisitos se
desvían y su conocimiento del problema aumenta. El código necesita
seguir el ritmo.
■ Uso: A medida que personas reales en circunstancias reales van
usando el sistema, se da cuenta de que ahora algunas características
son más importantes de lo que había pensado en principio y
características que parecían imprescindibles quizá no lo son.
■ Rendimiento: Necesita pasar funcionalidad de un área del sistema a
otra para mejorar el rendimiento.
■ Las pruebas se pasan: Sí. En serio. Hemos dicho que la
refactorización debería ser una actividad a pequeña escala, respaldada
por pruebas buenas. Así pues, cuando ha añadido una pequeña
cantidad de código y esa prueba extra se pasa, tiene una gran
oportunidad de ponerse a limpiar lo que acaba de escribir.

pagina 286

