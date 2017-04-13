using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5簡易留言版.Models;

namespace MVC5簡易留言版.Services
{
    public class messageDBService
    {
        //實作資料庫模型
        public messageEntities db = new messageEntities();

        //方法: 取得 Article 資料並回傳
        public List<Article> GetData()
        {
            return db.Article.ToList();
        }

        //方法: 將輸入資料存入DB
        public void DBCreate(string article_title, string content)
        {
            //實作 Article 資料表
            Article NewData = new Article();

            //將輸入的資料存放在 NewData 中 (NewData為實作DB資料表, 所以可以直接Add至DB)
            NewData.Title = article_title;
            NewData.Content = content;
            NewData.CreateTime = DateTime.Now;

            //新增一筆資料
            db.Article.Add(NewData);

            //存入 DB
            db.SaveChanges();
        }
    }
}