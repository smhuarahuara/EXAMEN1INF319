suma x y = x + y
resta x y = x - y
multiplicacion x y = x * y
divi x y =  div x y

main = do
    print "Seleccione la operacion que desea realizar"
    print "[1] Suma"
    print "[2] Resta"
    print "[3] Multiplicacion"
    print "[4] Division"
    n <-getLine
    print "Ingrese los valores"
    a <- getLine
    b <- getLine
    let x = read a :: Integer
    let y = read b :: Integer
    let s1 = suma x y
    let s2 = resta x y
    let s3 = multiplicacion x y
    let s4 = divi x y
    print "El resultado es"
    if n == "1" then print (s1) else return()
    if n == "2" then print (s2) else return()
    if n == "3" then print (s3) else return()
    if n == "4" then print (s4) else return()