export class Singleton {

  // Static instance of the class
  // Instancia estática de la clase
  private static instance: Singleton;

  // Private Constructor
  // Constructor privado
  private constructor() {
    console.log("Instance Created");
  }

  // Method that controls the access to the instance
  // Método que controla el acceso a la instancia
  public static getInstance(): Singleton {
    if (!Singleton.instance) {
      Singleton.instance = new Singleton();
    }

    return Singleton.instance
  }

  // Class Method
  // Método de clase
  public saludar(): void {
    console.log("Hi I am a singleton");
  }
}

const s1 = Singleton.getInstance()

const s2 = Singleton.getInstance()

s1.saludar()

// true → If both reference the same object
// true → Si ambas referencian al mismo objeto
console.log(s1 === s2);