using System;
					
public class Cajero
{
	string nombre;
	int saldo;
	
	
	public static void Main()
	{
		
			
		Cajero persona1 = new Cajero();
		
		Console.WriteLine("Cajero automático");
		Console.WriteLine("");
		Console.WriteLine("Favor de ingresar su nombre completo");
		persona1.nombre = Console.ReadLine();
		Console.WriteLine("");
	

		
		
		int res;
		int r;
		do
		{
		Console.WriteLine(persona1.nombre + " ¿Qué tipo de transacció deseas realizar?");
		Console.WriteLine("");
		Console.WriteLine("1 = Retiro");
		Console.WriteLine("2 = Deposito");
		Console.WriteLine("3 = Salir");
		Console.WriteLine("");

			
		res = int.Parse(Console.ReadLine());
			
		
		
		switch(res)
		{
			case 1:
				Console.WriteLine("¿Qué cantidad desea retirar?");
		        int cantidad = int.Parse(Console.ReadLine());
				persona1.retiro(cantidad);
				r=0;
		
				break;
				
			case 2:
				Console.WriteLine("¿Qué cantidad desea depositar?");
		        cantidad= int.Parse(Console.ReadLine());
				persona1.deposito(cantidad);
				r=0;
				break;
				
			case 3: 
				Console.WriteLine("Cerrando sesión " + persona1.nombre);
				Console.WriteLine("Puede retirar su tarjeta");
				Console.WriteLine("....");
				Console.WriteLine("Que tenga un buen día");
				r=2;
				break;
				
			default:
				Console.WriteLine("Esta opción no existe");
				r=0;
				break;
		
		}
		
		}while(r<2);
	
				
	}
	
	
	public int retiro(int cantidad)
	{
				if(saldo <= cantidad)
				{
				Console.WriteLine("Transacción invalida. Fondos insuficientes");
				Console.WriteLine("");
				return saldo;
				
				}else
				{
				Console.WriteLine("Se ha retirado la cantidad de: " + cantidad);
				saldo = saldo - cantidad;
				Console.WriteLine("Su saldo actual es de " + saldo + "$");
				Console.WriteLine("");
				return saldo;
				}
		
	}
	
	public int deposito(int cantidad)
	{
		Console.WriteLine("Se ha depositado la cantidad de: " + cantidad + "$");
		saldo = saldo + cantidad;
		Console.WriteLine("Su saldo actual es de " + saldo + "$");
		Console.WriteLine("");
		return saldo;
	}
	
}