﻿using MyBlog.EntitiyLayer.Concrete;

namespace MyBlog.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        List<Article> TGetArticlesByWriter(int id);
    }
}

