public class Libro{
    private String titulo;
    private String autor;
    private int ejemplares;
    private int prestados;

    public Libro(String titulo, String autor, int ejemplares, int prestados){
        this.titulo = titulo;
        this.autor = autor;
        this.ejemplares;
        this.prestados;
        
    }

    public String getTitulo() {
		return this.titulo;
		
	}
	
	public String getAutor() {
		return this.autor;
		
	}
	public int getEjemplares() {
		return this.ejemplares;
		
	}
	
	public int getPrestados() {
		return this.prestados;
		
	}
	
	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}
	
	public void setAutor(String autor) {
		this.autor = autor;
	}
	
	public void setPrestados(int prestados) {
		this.prestados = prestados;
	}
	
	public void setEjemplares(int ejemplares) {
		this.ejemplares = ejemplares;
	}

    public boolean prestamo(){
        if(this.ejemplares > this.prestados){
			this.prestados++;
			return true;
	
		}else return false;
    }

    public boolean devolucion(){

        if(this.prestados == 0){
			this.prestados--;
			return true;
			
		}else return false;
			
	}

    public void mostrar(){
        Console.WriteLine(this.titulo);
        Console.WriteLine(this.autor);
        Console.WriteLine(this.ejemplares);
        Console.WriteLine(this.prestados);
    }
        
    }
