double costoFijo, costoVariable, precioVenta, puntoEquilibrio;
string? respuesta="";

Console.WriteLine("Bienvenido/a ♥\nAquí se calculará el punto de equilibrio.");

/*
Antes de comenzar a operar, utilicé un mientras para
que cuando termine de informar el punto de equilibrio
se vuelva a preguntar si desea seguir operando o no.
*/
while(respuesta != "no"){
    //Empiezo a pedir por consola el costoFijo, costoVariable y precioVenta
    Console.WriteLine("Ingresar el costo fijo ANUAL: ");
    costoFijo=Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresar el costo variable: ");
    costoVariable= Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresar el precio de venta del artículo: ");
    precioVenta= Convert.ToDouble(Console.ReadLine());

    //Acá se realiza el calculo entre el costoFijo diviendo la resta entre precioVenta y costoVariable
    puntoEquilibrio= (costoFijo / (precioVenta - costoVariable));
    Console.WriteLine("Para alcanzar el punto de equilibrio, se necesitan vender "+puntoEquilibrio+" unidades.");

    //Declaro la variable respuesta, para que cuando se ingrese un "no", corte el flujo del programa
    Console.WriteLine("¿Desea realizar otra operación?\nIngrese si para continuar\nIngrese no para finalizar");
    respuesta= Console.ReadLine();
}

Console.WriteLine("Hasta la próxima!!!");
