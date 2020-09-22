using Food3.Adapters;
using Food3.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food3.Services
{
    class AddCartService
    {
       public static void AddtoCart(Cart cart)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_Cart();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            
            var sqlString = "INSERT INTO Carts(id,name,image,description,price,quantity) VALUES(?,?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, cart.id);
            stt.Bind(2, cart.name);
            stt.Bind(3, cart.image);
            stt.Bind(4, cart.description);
            stt.Bind(5, cart.price);
            stt.Bind(6, cart.Quantity);
            stt.Step();
        }

       public static List<Cart> getDataCart()
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_Cart();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;

            var sqlString = "SELECT * FROM Carts";
            var stt = sQLiteConnection.Prepare(sqlString);
            List<Cart> arr = new List<Cart>();
            while (SQLiteResult.ROW == stt.Step())
            {

                Cart c = new Cart(
                   Convert.ToInt32(stt[0]), (string)stt[1], (string)stt[2], (string)stt[3], Convert.ToInt32(stt[4]),
                    Convert.ToInt32(stt[5]));

                arr.Add(c);

            }
            return arr;
        }

       public static void deleteProduct(int id)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_Cart();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var stt = sQLiteConnection.Prepare("DELETE FROM Carts WHERE id = " + id);
            stt.Step();
        }

        //update sản phẩm đã có trong giỏ hàng
        public static void updateQuantity(int id,int quantity)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_Cart();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sql = " UPDATE Carts SET quantity = '"+quantity+" ' WHERE id = "+id;
            var stt = sQLiteConnection.Prepare(sql);
            stt.Step();
        }
    }
}
