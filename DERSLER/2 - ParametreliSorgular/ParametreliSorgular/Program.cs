using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliSorgular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategoriye göre ürün listelemek

            //SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand komut = baglanti.CreateCommand();

            //komut.CommandText = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryID";
            //baglanti.Open();

            //SqlDataReader okuyucu = komut.ExecuteReader();

            //while (okuyucu.Read())
            //{
            //    int id = okuyucu.GetInt32(0);
            //    string isim = okuyucu.GetString(1);
            //    Console.WriteLine($"{id}) {isim}");
            //}

            //okuyucu.Close();

            //Console.WriteLine("Ürünleri seçmek istediğiniz kategori numarasını yazınız: ");
            //string katNo = Console.ReadLine();

            //komut.CommandText = "SELECT ProductID, ProductName, UnitPrice FROM Products WHERE CategoryID=@murtaza";
            //komut.Parameters.AddWithValue("@murtaza", katNo);

            //SqlDataReader urunokuyucu = komut.ExecuteReader();
            //while (urunokuyucu.Read())
            //{
            //    int id = urunokuyucu.GetInt32(0);
            //    string isim = urunokuyucu.GetString(1);
            //    decimal fiyat = urunokuyucu.GetDecimal(2);
            //    Console.WriteLine($"{id}) {isim} {fiyat}");
            //}

            //baglanti.Close();

            #endregion

            #region Ürün Ekleyelim

            //Console.WriteLine("Ürün adı giriniz: ");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Ürünün kategori numarasını giriniz: ");
            //int katNo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Paketleme türünü giriniz: ");
            //string paketleme = Console.ReadLine();

            //Console.WriteLine("Ürün fiyatı yazınız: ");
            //decimal fiyat = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Stok miktarını giriniz: ");
            //short stok = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Ürün satışta mı? e/h");
            //bool satistami = true;
            //string secenek = Console.ReadLine();

            //if (secenek == "h")
            //{
            //    satistami = false;
            //}

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");

            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "INSERT INTO Products(ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued) VALUES (@productName, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @discontinued)";
            //cmd.Parameters.AddWithValue("@productName", isim);
            //cmd.Parameters.AddWithValue("@categoryID", katNo);
            //cmd.Parameters.AddWithValue("@quantityPerUnit", paketleme);
            //cmd.Parameters.AddWithValue("@unitPrice", fiyat);
            //cmd.Parameters.AddWithValue("@unitsInStock", stok);
            //cmd.Parameters.AddWithValue("@discontinued", satistami);

            //con.Open();
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Ekleme işlemi başarılı");
            //con.Close();


            #endregion

        }
    }
}
