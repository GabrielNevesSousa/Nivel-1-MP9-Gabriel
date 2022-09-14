public class Cuenta{
    private String titular;
    private double cantidad;
}

public Cuenta (String Titular, double Cantidad){
    this.Titular = titular;
    this.Cantidad = cantidad;
}

private void setTitular(String Titular){
    this.Titular = titular;

}

private void setCantidad(double Cantidad){
    this.Cantidad = cantidad;

}

private String.getTitular(){
    return this.titular;

}

private double.getCantidad(){
    return this.cantidad;

}

public void Mostrar(){

    Console.WriteLine("Titular" + this.Titular);
    Console.WriteLine("Cantidad" + this.getCantidad);
    
}

public void Ingresar(double cantidad){
    if(cantidad > 0){
        this.cantidad + = cantidad;
    }
}

public void Retirar(double cantidad){
    if (this.cantidad - cantidad < 0) {
            this.cantidad = 0;
        } else {
            this.cantidad -= cantidad;
        }
}