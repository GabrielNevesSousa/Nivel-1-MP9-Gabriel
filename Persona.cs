public class persona{
    private String nombre;
    private String DNI;
    private int edad;
}

public persona (String nombre, String DNI, int edad){
    this.nombre = nombre;
    this.DNI = DNI;
    this.edad = edad
}

private void setNombre(String nombre){
    this.nombre = nombre;

}

private void setDNI(String DNI){
    this.DNI = DNI;

}

private void setEdad(int edad){
    this.edad = edad;

}

private String.getNombre(){
    return this.nombre;

}

private String.getDNI(){
    return this.DNI;

}

private int.getEdad(){
    return this.edad;

}

public void MostrarInformacion(){

    Console.WriteLine("Nombre" + this.getNombre);
    Console.WriteLine("DNI" + this.getDNI);
    Console.WriteLine("Nombre" + this.getEdad);
}

public void esMayorDeEdad(){
    if (this.getEdad >= 18){
        Console.WriteLine("Es mayor de edad");
    }else{
        Console.WriteLine("Es menor de edad");
    }

}
