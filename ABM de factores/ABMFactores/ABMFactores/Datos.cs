using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABMFactores
{
    class Datos
    {
        public void Guardar(Factor f)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" + 
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "insert into factor (idfactor, nombre) values (" + f.IDFactor + ",'"
                                        + f.NombreFactor + "');";

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Guardado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Guardar(Valor v)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "insert into valor (idvalor, denominacion, numvalor, idfactor) values (" +
                                        v.IDValor + ", '" + v.Denominacion + "', " + v.NumValor + ", " +v.IDFactor+");";

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Guardado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Mostrar()
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "select * from factor;";

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    try
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(string.Format("{0},{1}", reader[0], reader[1]));
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Mostrar(Int32 i)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "select * from valor where valor.idfactor = " + i;

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    try
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(string.Format("{0},{1},{2},{3}", reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Borrar(Int32 i)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "delete from factor where factor.idfactor = " + i;

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Eliminado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Modificar(Int32 i, Factor f)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "update factor set factor.idfactor = @id, factor.nombre = @nombre where factor.idfactor = @idf";

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    SqlParameter id = new SqlParameter("@id", f.IDFactor);
                    id.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter nombre = new SqlParameter("@nombre", f.NombreFactor);
                    nombre.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter idf = new SqlParameter("@idf", i);
                    idf.Direction = System.Data.ParameterDirection.Input;

                    cmd.Parameters.Add(id);
                    cmd.Parameters.Add(nombre);
                    cmd.Parameters.Add(idf);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Modificado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Modificar(Int32 i, Valor v)
        {
            string DatosConexion = "Data Source = DR3-PC\\SQLEXPRESS;" +
                                    "Initial Catalog = TrabajoPractico; Integrated Security = true;";

            try
            {
                using (SqlConnection con = new SqlConnection(DatosConexion))
                {
                    con.Open();

                    string TextoCmd = "update valor set valor.idvalor = @id, valor.denominacion = @den, valor.numvalor = @valor,  valor.idfactor = @idf where valor.idvalor = @idv";

                    SqlCommand cmd = new SqlCommand(TextoCmd, con);

                    SqlParameter id = new SqlParameter("@id", v.IDValor);
                    id.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter den = new SqlParameter("@den", v.Denominacion);
                    den.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter valor = new SqlParameter("@valor", v.NumValor);
                    valor.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter idf = new SqlParameter("@idf", v.IDFactor);
                    idf.Direction = System.Data.ParameterDirection.Input;

                    SqlParameter idv = new SqlParameter("@idv", i);
                    idv.Direction = System.Data.ParameterDirection.Input;

                    cmd.Parameters.Add(id);
                    cmd.Parameters.Add(den);
                    cmd.Parameters.Add(valor);
                    cmd.Parameters.Add(idf);
                    cmd.Parameters.Add(idv);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Modificado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
