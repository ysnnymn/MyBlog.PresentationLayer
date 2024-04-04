using System;
using Autofac;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.BusinessLayer.Concrete;
using MyProject.DataAccessLayer.Abstract;
using MyProject.DataAccessLayer.EntityFramework;

namespace MyBlog.BusinessLayer.DependcyResolvers.Autofac
{
	public class AutofacBussinessModule:Module
	{
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleManager>().As<IArticleService>().SingleInstance();
            builder.RegisterType<EfArticleDal>().As<IArticleDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommenetService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();

            builder.RegisterType<TagManager>().As<ITagService>().SingleInstance();
            builder.RegisterType<EfTagDal>().As<ITagDal>().SingleInstance();

            builder.RegisterType<WriterManager>().As<IWriterService>().SingleInstance();
            builder.RegisterType<EfWriterDal>().As<IWriterDal>().SingleInstance();
        }
    }
}

