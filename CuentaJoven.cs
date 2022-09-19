public class CuentaJoven extends Cuenta {
	
	private String titular;
	private double cantidad;
	private int edad;
	
	public CuentaJoven (String titular, double cantidad, int edad) {
        super(titular, cantidad);
		this.edad = edad;
        
		
	}
	
	
	public int getEdad() {
		return this.edad;
		
	}
	
	
	public void setEdad(int edad) {
		this.edad = edad;
		
	}

	public boolean esTitularValido() {
		if(this.edad >= 18 && this.edad < 25){
			return true;
			
		}else
			return false;
		
	}
	public void mostrar() {
		super(titular, cantidad);
		Console.WriteLine(this.edad);
	}
	
	public void ingresar(double cantidadI) {
		if(cantidadI > 0) {
			this.cantidad = this.cantidad + cantidadI;
		}
		
	}
	
	public void retirar(double cantidadR) {
		if(this.esTitularValido()){
		if( cantidadR > 0)  {
			this.cantidad = this.cantidad - cantidadR;
			
		}
		
	}
		
	}
}
