using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using NuGet.Protocol.Plugins;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Panel.Controllers
{
    public class WriterController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public WriterController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            connection.ConnectionString = _configuration.GetConnectionString("BookSell");
            _environment = environment;
        }

        SqlConnection connection = new SqlConnection();
       

        public ActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.booksWriters", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Writer> yazar = new List<Writer>();

            foreach (DataRow row in dt.Rows)
            {
                yazar.Add(new Writer
                {
                    writerID = Convert.ToInt32(row["writerID"].ToString()),
                    writerName = row["writerName"].ToString()
                });


            }


            return View(yazar);
        }

        private Writer GetID(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.booksWriters where writerID=@writerID", connection);
            da.SelectCommand.Parameters.AddWithValue("writerID", id);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Writer yazar = new Writer
            {
                writerID = Convert.ToInt32(dt.Rows[0]["writerID"].ToString()),
                writerName = dt.Rows[0]["writerName"].ToString()
            };

            return (yazar);

        }
        // GET: WriterController/Details/5
        public ActionResult Details(int id)
        {
            Writer yazar = GetID(id);
            return View(yazar);
        }

        // GET: WriterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WriterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Writer yazar)
        {
            if (ModelState.IsValid)
            {
                SqlCommand command = new SqlCommand("insert into dbo.booksWriters values (@writerName)", connection);
                command.Parameters.AddWithValue("writerName", yazar.writerName);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));

            }
            else
                return View(yazar);
        }

        // GET: WriterController/Edit/5
        public ActionResult Edit(int id)
        {
            Writer yazar = GetID(id);
            return View(yazar);
        }

        // POST: WriterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Writer yazar)
        {
            if (ModelState.IsValid)
            {
                SqlCommand cmd = new SqlCommand("update dbo.booksWriters set writerName=@writerName where writerID=@writerID", connection);
                cmd.Parameters.AddWithValue("writerID", yazar.writerID);
                cmd.Parameters.AddWithValue("writerName", yazar.writerName);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));

            }
            else
                return View(yazar);
        }

        // GET: WriterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetID(id));
        }

        // POST: WriterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Writer yazar)
        {
            SqlCommand command = new SqlCommand("delete from dbo.booksWriters where writerID=@writerID", connection);
            command.Parameters.AddWithValue("writerID", yazar.writerID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return RedirectToAction(nameof(Index));
        }
    }
}
