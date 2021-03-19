namespace RestTEC.DB
{
    public class Usuario
    {
        public int cedula;
        public string correo;
        private string contrasena;
        public string nombre;
        public string apellido;
        public int numero;
        public string direccion;
        public int fecha_Nacimiento;

        public Usuario(int cedula, string correo, string contrasena, string nombre, string apellido, int numero, string direccion, int fechaNacimiento)
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
    }
}