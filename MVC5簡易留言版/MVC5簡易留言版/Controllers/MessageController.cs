using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5簡易留言版.Models;
using MVC5簡易留言版.Services;

namespace MVC5簡易留言版.Controllers
{
    public class MessageController : Controller
    {
        //實作 Service 物件
        messageDBService rec = new messageDBService();

        // GET: Message
        public ActionResult Index()
        {
            //讀取DB資料傳回View去顯示
            return View(rec.GetData());
        }

        //檢視Create
        public ActionResult Create()
        {
            return View();
        }

        //執行Create  Summit的動作
        [HttpPost]
        public ActionResult Create(string article_title, string content)
        {
            rec.DBCreate(article_title, content);
            return RedirectToAction("Index");
        }
    }
}