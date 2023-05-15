using System;

class Pizzeria{
    static void Main(String[] args){
        
        int hawaina = 150;
        int pepperoni = 155;
        int quesos = 145;
        int margarita = 168;
        int salami = 159;

        Console.WriteLine("**************************************");
        Console.WriteLine("App PIZZERÍA");
        Console.WriteLine("**************************************");
           
                
        Console.WriteLine("Menú de pizzas");
        Console.WriteLine("1.- Hawaiana $150");
        Console.WriteLine("2.- Pepperoni $155");
        Console.WriteLine("3.- Quesos $145");
        Console.WriteLine("4.- Margarita $168");
        Console.WriteLine("5.- Salami $159");
        int opcPizzas = int.Parse(Console.ReadLine());
        switch(opcPizzas){
            case 1:
                Console.WriteLine("Eligio la pizza Hawaiana");
                Console.WriteLine("Costo: $150.00");
                Console.WriteLine("¿Su pedido será llevado a su domicilio (+$45)?  1.- Si   2.- No");
                int dom = int.Parse(Console.ReadLine()); 
                switch(dom){
                    case 1:
                        Console.WriteLine("Se le cargará un monto extra de $45.00");
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta = int.Parse(Console.ReadLine()); 
                        switch (tarjeta){
                            case 1:
                                double subtotal = (hawaina + 45)*.03;
                                double total = (hawaina + 45) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (hawaina + 45);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta2 = int.Parse(Console.ReadLine()); 
                        switch (tarjeta2){
                            case 1:
                                double subtotal = (hawaina)*.03;
                                double total = (hawaina) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (hawaina);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            break;
            case 2:
                Console.WriteLine("Eligio la pizza Pepperoni");
                Console.WriteLine("Costo: $155.00");
                Console.WriteLine("¿Su pedido será llevado a su domicilio (+$45)?   1.- Si   2.- No");
                int dom2 = int.Parse(Console.ReadLine()); 
                switch(dom2){
                    case 1:
                        Console.WriteLine("Se le cargará un monto extra de $45.00");
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta = int.Parse(Console.ReadLine()); 
                        switch (tarjeta){
                            case 1:
                                double subtotal = (pepperoni + 45)*.03;
                                double total = (pepperoni + 45) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (pepperoni + 45);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta2 = int.Parse(Console.ReadLine()); 
                        switch (tarjeta2){
                            case 1:
                                double subtotal = (pepperoni)*.03;
                                double total = (pepperoni) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (pepperoni);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    default:
                        break;
                }
                break;
            case 3: 
                Console.WriteLine("Eligio la pizza quesos");
                Console.WriteLine("Costo: $145.00");
                Console.WriteLine("¿Su pedido será llevado a su domicilio (+$45)?  1.- Si   2.- No");
                int dom3 = int.Parse(Console.ReadLine()); 
                switch(dom3){
                    case 1:
                        Console.WriteLine("Se le cargará un monto extra de $45.00");
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta = int.Parse(Console.ReadLine()); 
                        switch (tarjeta){
                            case 1:
                                double subtotal = (quesos + 45)*.03;
                                double total = (quesos + 45) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (quesos + 45);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta2 = int.Parse(Console.ReadLine()); 
                        switch (tarjeta2){
                            case 1:
                                double subtotal = (quesos)*.03;
                                double total = (quesos) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (quesos);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    default:
                        break;
                }
                break;
            case 4:
                Console.WriteLine("Eligio la pizza Margarita");
                Console.WriteLine("Costo: $168.00");
                Console.WriteLine("¿Su pedido será llevado a su domicilio (+$45)?  1.- Si   2.- No");
                int dom4 = int.Parse(Console.ReadLine()); 
                switch(dom4){
                    case 1:
                        Console.WriteLine("Se le cargará un monto extra de $45.00");
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta = int.Parse(Console.ReadLine()); 
                        switch (tarjeta){
                            case 1:
                                double subtotal = (margarita + 45)*.03;
                                double total = (margarita + 45) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (margarita + 45);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta2 = int.Parse(Console.ReadLine()); 
                        switch (tarjeta2){
                            case 1:
                                double subtotal = (margarita)*.03;
                                double total = (margarita) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (margarita);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    default:
                        break;
                }
                break;
            case 5:
                Console.WriteLine("Eligio la pizza Salami");
                Console.WriteLine("Costo: $159.00");
                Console.WriteLine("¿Su pedido será llevado a su domicilio (+$45)?  1.- Si   2.- No");
                int dom5 = int.Parse(Console.ReadLine()); 
                switch(dom5){
                    case 1:
                        Console.WriteLine("Se le cargará un monto extra de $45.00");
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta = int.Parse(Console.ReadLine()); 
                        switch (tarjeta){
                            case 1:
                                double subtotal = (salami + 45)*.03;
                                double total = (salami + 45) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (salami + 45);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Elija su forma de pago: 1.- Pagos con tarjeta debido/credito(+3%)   2.-Efectivo");
                        int tarjeta2 = int.Parse(Console.ReadLine()); 
                        switch (tarjeta2){
                            case 1:
                                double subtotal = (salami)*.03;
                                double total = (salami) + subtotal;
                                Console.WriteLine($"Su total a pagar es de: {total}");
                                break;
                            case 2:
                                double subtotal2 = (salami);
                                Console.WriteLine($"Su total a pagar es de: {subtotal2}");
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        break;
                    default:
                        break;
                }
                break;
            default:
                Console.WriteLine("Opción incorrecta");
                break;
        }
        
    
                        
    }
}