using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using XF.tp3.Droid;
using System.Threading;
using Android.Webkit;
using System.IO;
using SQLite;
using XF.tp3.Data;

[assembly:
Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace XF.tp3.Droid
{
    public class SQLite_Android : Data.ISQLite
    {
        public SQLite_Android() { }

        public SQLiteConnection GetConexao()
        {
            var arquivodb = "ifspdb.db3";
            string caminho = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var local = System.IO.Path.Combine(caminho, arquivodb);

            var conexao = new SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}