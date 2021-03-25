using System;

namespace RestTEC.DB
{
    //Clase Usuario, es la clase que contiene la informacion y la utilidad de los usuarios 
    // incritos a RESTEC.
    public class Usuario 
    {
        //Atributos
        public int cedula;
        public string correo;
        private string contrasena;
        public string nombre;
        public string apellido;
        public int numero;
        public string direccion;
        public int fecha_Nacimiento;

        //Constructor, getters y setters
        public Usuario(int cedula, string correo, string contrasena, string nombre,
                        string apellido, int numero, string direccion, int fechaNacimiento)
        {
            this.cedula = cedula;
            this.correo = correo;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
            this.direccion = direccion;
            fecha_Nacimiento = fechaNacimiento;
        }
        
        public int Cedula
        {
            get => cedula;
            set => cedula = value;
        }

        public string Correo
        {
            get => correo;
            set => correo = value;
        }

        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public int FechaNacimiento
        {
            get => fecha_Nacimiento;
            set => fecha_Nacimiento = value;
        }
        
                //Funcionalidad usuario
        
        // Funcion que pide los datos necesarios para crear un pedido en el sistema
        // Entradas: esta funcion no tiene entradas, pero el sistema le pide al cliente que ingrese
        //          el pedido que desea
        // Salidas: la salida es un pedido o null si hubo un error en el proceso
        // Resticciones: el numero del pedido tiene que existir en el sistema y tiene que ser un int
        public Pedido hacer_pedido()
        {
            Console.WriteLine("Ingrese el numero del pedido a realizar");
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            try
            {
                if (Menu.Lista_Platos != null)
                {
                    Console.WriteLine("Se hizo un pedido del plato: " + num);
                    num = num - 1;
                    return new Pedido(null, Menu.obtener_Menu()[num],
                        Menu.obtener_Menu()[num].tiempoEstimado);
                }
                else
                {
                    Console.WriteLine("El plato numero "+ num + " no existe");
                    return null;   
                }
            }
            catch
            {
                Console.WriteLine("El plato no existe");
                return null;
            }
        }
        // Funcion que crea un feedback y lo asigna al plato
        // Entradas: l anetrada es un Usuario, un fecha, hora, estrllas
        // Salidas:la salida es un feedback ya creado
        // Resticciones: el Usuario tiene que ser un objeto ya creado, la fecha y hora son strings
        //              y las estrellas son un entero mayor que cero
        public FeedBack hacer_Feedback(Usuario usuario, string fecha, string hora, int estrellas)
        {
            
            return new FeedBack(usuario,fecha,hora,estrellas);
        }
    }
}