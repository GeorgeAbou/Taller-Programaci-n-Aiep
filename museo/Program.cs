using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace museo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LISTADO CON 2 ADMINISTRADORES
            //PASO 1 CREAR LISTA VACIA
            //List<Nombreclase>nombrelista=new List <Nombre Clase>();
            List<Administrador> listadoAdministradores = new List<Administrador>();

            //PASO 2 agregar objetos directamente en el listado (utilizamos metodoconstructor)
            listadoAdministradores.Add(new Administrador(1, "abu123", "George", "Abou", "aaa1111"));
            listadoAdministradores.Add(new Administrador(2, "aD12333", "fernando", "Perez", "bbbb131"));

            //LISTADO CON 2 GUIAS
            List<Guia> listadoGuias = new List<Guia>();
            listadoGuias.Add(new Guia(125695, "GuiaGuille", "Guillermo", "Perez", "52658w"));
            listadoGuias.Add(new Guia(125695, "GuiaKarim", "Karim", "Lopez", "51253e"));

            //LISTADO CON 4 OBRAS DE ARTE
            List<ObraArte> listadorObras = new List<ObraArte>();
            listadorObras.Add(new ObraArte(25896, "Guiernica", "Pablo Picasso", "1973", "Sufrimiento de los españoles guerra civil"));
            listadorObras.Add(new ObraArte(25896, "La Gioconda", "Leonardo Da Vinci", "1503-1519", "Retrado de una dama"));
            listadorObras.Add(new ObraArte(25896, "La Noche Estrellana ", "Vicent Van Gogh", "1452-1519", "Refleja Ultima cena de jesus con sus apóstoles"));
            listadorObras.Add(new ObraArte(25896, "La Ultima Cena ", "Leonardo Da Vinci", "1973", "Sufrimiento de los españoles guerra civil"));

            //LISTADO CON DOS EXPOSICIONES
            //Expo con 3 obras Listado auxiliar de obras agregadas a exposicion
            List<ObraArte> obrasexposicion1 = new List<ObraArte>();

            //Utilizando 3 obras del listado original en listado de exposicion
            obrasexposicion1.Add(listadorObras[0]);
            obrasexposicion1.Add(listadorObras[1]);
            obrasexposicion1.Add(listadorObras[2]);

            Exposicion exposicion1 = new Exposicion(1, "Mejores Obras", "03-11-2023", "10-11-2023", obrasexposicion1);
            //expo con 2 obras
            List<ObraArte> obrasexposicion2 = new List<ObraArte>();

            obrasexposicion2.Add(listadorObras[2]);
            obrasexposicion2.Add(listadorObras[3]);
            Exposicion exposicion2 = new Exposicion(2, "Obras Sentimentales", "11-11-2023", "10-18-2023", obrasexposicion2);

            // Listado de expopsiciones
            List<Exposicion> listadoexposiciones = new List<Exposicion>();
            listadoexposiciones.Add(exposicion1);
            listadoexposiciones.Add(exposicion2);

            //LISTADO CON UNA GALERIA y UNA EXPOSICION

            //CREANDO LISTA CON EXPOSICIONY GALERIA 

            List<Exposicion> listadoExposicionGaleria = new List<Exposicion>();

            //aGREGANDOLE LA EXPOSCION 1
            listadoExposicionGaleria.Add(exposicion1);


            // AGREGANDOLE LA GALERIA 
            //CREANDO LA GALERIA LA CUAL DENTRO DE SU PARAMETROS INCLUYE  istadoExposicionGaleria)
            Galeria miGaleria = new Galeria(1, "Mi Galeria", listadoExposicionGaleria);
            //FIANALMENTE SE CREA UNA LISTA DE GALERIAS
            List<Galeria> listadoGalerias = new List<Galeria>();
            //Se agrega la galeria "miGaleria" al listado , asi cumñiendo con el enunciado que quiere cear un listado de galerias
            //donde una galeria incluya una exposicion.
            listadoGalerias.Add(miGaleria);

            //Validar que existe Usuario
            string tipoUser = loginUsuario(listadoAdministradores, listadoGuias);
            if (tipoUser == "GUIA")


            {

                int opcionGuia = MenuGuia();
                switch (opcionGuia)

                {
                    case 1:
                        VerListadoGalerias(listadoGalerias);
                        break;
                    case 0:
                        Console.WriteLine("Hasta Luego");
                        break;



                }

                if (tipoUser == " ADMINISTRADOR")
                {
                    int opcionAd = MenuAdministrador();
                    switch (opcionAd)
                    {
                        case 1:
                            //Console.WriteLine("1-VER LISTADO DE Guias");
                            //LLamar metodo verlistadoGuias
                            VerListadoGuias(listadoGuias);
                            break;
                        case 2:
                            //Console.WriteLine("2 Ver Listado de Obras de Arte");
                            VerListadoObras(listadorObras);
                            break;

                        case 3:
                            VerListadoExposiciones(listadoexposiciones);
                            break;
                        case 4:
                            VerListadoGalerias(listadoGalerias);
                            break;
                        case 5:
                            Console.WriteLine("5 Agregar Galería");
                            //pedri datos
                            Console.WriteLine("Ingrese Id:");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese nombre :");
                            string nombre = Console.ReadLine();
                            VerListadoExposiciones(listadoexposiciones);
                            //deberia ser un ciclo para agregar mas de 1 listado
                            Console.WriteLine("Ingrese Id de las Expsoicon a agregar:");
                            int idExpo = int.Parse(Console.ReadLine());
                            List<Exposicion> listaExpoAgregar = new List<Exposicion>();
                            //buscar expo a agregar por id y guardarel objeto en el listado
                            foreach (var exposicion in listadoexposiciones)
                            {
                                if (exposicion.Id == idExpo)
                                {
                                    listaExpoAgregar.Add(exposicion);

                                }
                            };
                            Galeria gal = new Galeria(id, nombre, listaExpoAgregar);
                            listadoGalerias.Add(gal);
                            Console.WriteLine($"se agrego galeria {gal.NombreGaleria}");
                            Console.WriteLine();
                            break;




                        case 6:

                            break;

                        //case6


                        case 0:

                            Console.WriteLine("HASTA LUEGO");
                            break;

                        default:
                            Console.WriteLine("Opcion Incorrecta");
                            break;




                    };




                    

                };//FIN GUIA


            };//FIN ENTORNO


        }//FIN CLASE

        //AGREGAR METODOS ESTÁTICOS
        //MENU PARA ADMINISTRADOR
        static int MenuAdministrador()
        {
            Console.WriteLine("--MENU ADMINISTRADOR---");
            Console.WriteLine("1-VER LISTADO DE Guias");
            Console.WriteLine("2 Ver Listado de Obras de Arte");
            Console.WriteLine("3 Ver Listado de Exposicones");
            Console.WriteLine("4 Ver listado de Galerias ");
            Console.WriteLine("5 Agregar Galería");
            Console.WriteLine("6 Editar Galeria (Agregar exposición, verificar primero que no existe ya en la galería actual)");
            Console.WriteLine("0 Salir");
            int opcion = int.Parse(Console.ReadLine());//Sin validar que el tipo de dato de entrada sea int
            Console.ReadLine();
            //validamos el ingrreso para des´legar las opciones mediante un if
            return opcion;


        }
        //MENU PARA GUÍA
        static int MenuGuia()
        {
            Console.WriteLine("---Menú Guía");
            Console.WriteLine("1--Ver ListadoGalerias");
            Console.WriteLine("0--Salir");
            int opcion = int.Parse(Console.ReadLine());
            return 0;

        }
        //metodo para verlistado de guias
        static void VerListadoGuias(List<Guia> listadoGuias)
        {
            foreach (var guia in listadoGuias)
            {
                Console.WriteLine($"Usuario:{guia.Usuario} ");
                Console.WriteLine($"Nombnre :{guia.Nombre} {guia.Apellido} ");
                Console.WriteLine("----------------");
            }

        }
        //Metodo para ver listado de obras de arte
        static void VerListadoObras(List<ObraArte> listadoObras)
        {
            foreach (var ObraArte in listadoObras)
            {
                Console.WriteLine($"Nombnre:{ObraArte.NombreObra} ");
                Console.WriteLine($"Autor :{ObraArte.Autor}  ");
                Console.WriteLine($"Fecha :{ObraArte.Fecha}  ");
                Console.WriteLine($"Descripcion :{ObraArte.Descripcion}  ");

                Console.WriteLine();
            }
        }

        //metodo para ver listado de Exposiciones
        static void VerListadoExposiciones(List<Exposicion> listadoexposiciones)
        {
            foreach (var exposicion in listadoexposiciones)
            {
                Console.WriteLine($"EXPSOCION # {exposicion.Id}");
                Console.WriteLine($"ID:{exposicion.Id}");
                Console.WriteLine($"Nombre:{exposicion.Nombre}");
                Console.WriteLine($"fechas : {exposicion.FechaInicio} - {exposicion.FechaTermino}");
                //IMPRIMIR LISTADOP DE OBRAS DE LA EXPOSICION
                //LLAMAMOS AL METODO LISTADO DE OBRAS Y LO ASOCIOAMOS CON EL LISTADO DE CADA OBJETO
                Console.WriteLine($"---lista de obras pertenecientes a la exposcion: {exposicion.Id}--------");
                VerListadoObras(exposicion.ListadoObras);//aqui le llamamos al listado de cada objeto expo de la lista 
                Console.WriteLine("----FIN DE LA EXPOSCION ---");
                Console.WriteLine();
            }
        }

        //Ver listado galerias
        static void VerListadoGalerias(List<Galeria> listadoGalerias)


        {
            foreach (var galeria in listadoGalerias)
            {
                Console.WriteLine($"-----Galeria numero :{galeria.IdGaleria}-----");
                Console.WriteLine($" nombre:{galeria.NombreGaleria}");
                //Console.WriteLine($"Listao Exposiciones : {galeria.ListaExposiciones}");
                //SE USA DE NUEVO EL CODIGO DE LA FUNCION vERLISTADO EXPOSCIONES Y ASI SE EVITA HACER OTRO FOR EACH
                VerListadoExposiciones(galeria.ListaExposiciones);
                Console.WriteLine("----FIN DE LA GALERIA ---");
                Console.WriteLine();
            }


        }
        static String loginUsuario(List<Administrador> listaAdministrador, List<Guia> listadoGuias)
        {
            //Pedimos usuario
            Console.WriteLine("Ingrese su Usuario");
            string usuario = Console.ReadLine();
            //Pedimos contraseña
            Console.WriteLine("Ingrese su Contraseña");
            string password = Console.ReadLine();

            Console.WriteLine(usuario);
            Console.WriteLine(password);
            //Verificar si es Admin
            foreach (var administrador in listaAdministrador)
            {
                if (administrador.Usuario == usuario && administrador.Password == password)
                {
                    return "ADMINISTRADOR";
                }
            }
            //Verificar si es Guia
            foreach (var guia in listadoGuias)
            {
                if (guia.Usuario == usuario && guia.Password == password)
                {
                    return "GUIA";
                }
            }

            return "Usuario y/o Contraseña incorreectas ";

        }
        static Exposicion BuscarExposicion(int idbuscar, List<Exposicion> listadoExposiciones)
        {
            foreach (var expo in listadoExposiciones)

            {
                if (expo.Id == idbuscar)
                {
                    return expo;
                }
            }
            return null;
        }

    };
};

        

    

