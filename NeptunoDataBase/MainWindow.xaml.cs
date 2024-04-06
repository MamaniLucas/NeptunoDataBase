using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeptunoDataBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_ListarPrductos(object sender, RoutedEventArgs e)
        {

            string connectionString = "Data Source=LAB1504-10\\SQLEXPRESS;Initial Catalog=NeptunoDB; User Id=myriamdb; Password=123456";
            List<Productos> productos = new List<Productos>();


            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //
                SqlCommand command = new SqlCommand("USP_ListarProductos", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int idproducto = reader.GetInt32("idproducto");
                    string nombreProducto = reader.GetString("nombreProducto");
                    int idProveedor = reader.GetInt32("idProveedor");
                    int idCategoria = reader.GetInt32("idCategoria");
                    string cantidadPorUnidad = reader.GetString("cantidadPorUnidad");

                    productos.Add(new Productos { idproducto = idproducto, nombreProducto = nombreProducto, idProveedor = idProveedor, idCategoria = idCategoria, cantidadPorUnidad = cantidadPorUnidad });

                }
                connection.Close();
                dvgDemo.ItemsSource = productos;


            }catch (Exception ex) {


                MessageBox.Show(ex.Message);
                    
            }
        }

    }
    
}