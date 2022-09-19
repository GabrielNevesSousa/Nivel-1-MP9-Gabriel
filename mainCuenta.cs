public class mainCuenta {

	public static void main(String[] args) {
		
		CuentaJoven cj = new CuentaJoven("jaime", 50, 18);
		cj.ingresar(2);
		cj.retirar(2);
		cj.esTitularValido();
		cj.mostrar();

	}

}