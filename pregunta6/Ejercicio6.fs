// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let suma x y = x + y
let resta x y = x - y
let multiplicacion x y = x * y
let division x y = x / y

[<EntryPoint>] 
let main argv =
    
    Console.WriteLine("Bienvenido seleccione el numero de la opcion que desea realizar")
    Console.WriteLine("[1] Suma")
    Console.WriteLine("[2] Resta")
    Console.WriteLine("[3] Multiplicacion")
    Console.WriteLine("[4] Division")
    let piv = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("Ingrese los numeros a leer")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()

    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    if piv=1 then Console.WriteLine("La suma de "+num1+" y "+num2+" es igual a: "+(suma valor1 valor2).ToString()) 
    if piv=2 then Console.WriteLine("La resta de "+num1+" y "+num2+" es igual a: "+(resta valor1 valor2).ToString()) 
    if piv=3 then Console.WriteLine("La multipliacion de "+num1+" y "+num2+" es igual a: "+(multiplicacion valor1 valor2).ToString()) 
    if piv=4 then Console.WriteLine("La division de "+num1+" y "+num2+" es igual a: "+(division valor1 valor2).ToString()) 
     
     
    let tecla=Console.ReadKey() 
    0// devolver un código de salida entero
