# Ejemplo para la introducción de Xamarin con IOS.

Aplicación con un botón, un variable que se usa como contador y una etiqueta que se pinta el resultado del contador.

Cada vez que se pulsa sobre el botón se actualiza el valor de la etiqueta (Label).

VISTA en el Main.storyboard

	=> Agregamos un label con el nombre: labelResultado
	=> Agregamos un botón con el nombre: botonContar

ViewController agregamos:

	    public partial class ViewController : UIViewController
    {
        //definimos la variable contador
        int contador = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Asociamos un evento y asignamos el valor en el label
            botonContar.TouchDown += delegate { labelResultado.Text = this.Sumar(); };
         
        }

        /// <summary>
        /// Suma uno y retorna el resultado como una string. Ya que no podemos retorna directamente un int a un label
        /// </summary>
        /// <returns>String con el resultado de la suma</returns>
        private string Sumar()
        {
            contador++;
            return string.Format("{0}", contador);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
		

Cualquiera duda contacta por twitter: @elbrinner

