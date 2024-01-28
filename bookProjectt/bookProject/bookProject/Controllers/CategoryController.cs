using ClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Panel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public CategoryController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            connection.ConnectionString = _configuration.GetConnectionString("BookSell");
            _environment = environment;
        }

        SqlConnection connection = new SqlConnection();


        // GET: CategoryController
        public ActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.booksCategory",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Category> Kategori = new List<Category>();
            foreach (DataRow row in dt.Rows)
            {
                Kategori.Add(new Category
                {
                    categoryID = Convert.ToInt32(row["categoryID"].ToString()),
                    categoryName = row["categoryName"].ToString()
                });

            }


            return View(Kategori);
        }
        private Category GetID(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.booksCategory where categoryID=@categoryID", connection);
            da.SelectCommand.Parameters.AddWithValue("categoryID", id);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Category kategori = new Category
            {
                categoryID = Convert.ToInt32(dt.Rows[0]["categoryID"].ToString()),
                categoryName = dt.Rows[0]["categoryName"].ToString()
            };

            return (kategori);
          
        }


        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            Category kategori = GetID(id);
            return View(kategori);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category kategori)
        {
            if (ModelState.IsValid)
            {
                SqlCommand command = new SqlCommand("insert into dbo.booksCategory values (@categoryName)",connection);
                command.Parameters.AddWithValue("categoryName", kategori.categoryName);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
                
            }
            else
                return View(kategori);
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            Category kategori = GetID(id);
            return View(kategori);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category kategori)
        {
            if (ModelState.IsValid)
            {
                SqlCommand cmd = new SqlCommand("update dbo.booksCategory set categoryName=@categoryName where categoryID=@categoryID", connection);
                cmd.Parameters.AddWithValue("categoryID", kategori.categoryID);
                cmd.Parameters.AddWithValue("categoryName", kategori.categoryName);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));

            }
            else
                return View(kategori);
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetID(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category kategori)
        {
            SqlCommand command = new SqlCommand("delete from dbo.booksCategory where categoryID=@categoryID",connection);
            command.Parameters.AddWithValue("categoryID", kategori.categoryID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return RedirectToAction(nameof(Index));


        }
    }
}
