using MediatR;
using System.Reflection;
using LibCore.Repositories;
using LibInfrastructure.Repositories;
using LibApplication.Handlers.AnimalHandlers;
using LibApplication.Handlers.CommentHandlers;
using LibApplication.Handlers.CategoryHandlers;

namespace AnimalsASP
{
	public static class ConfigureServices
	{
		public static IServiceCollection AddProjectServices(this IServiceCollection services)
		{
			ConfigureMediatR(services);
			ConfigureRepositories(services);
			return services;
		}

		private static void ConfigureMediatR(IServiceCollection services)
		{
			// Category Handlers
			services.AddMediatR(typeof(CreateCategoryHandler).GetTypeInfo().Assembly);
			services.AddMediatR(typeof(GetAllCategoriesHandler).GetTypeInfo().Assembly);

			// Animal Handlers
			services.AddMediatR(typeof(CreateAnimalHandler).GetTypeInfo().Assembly);
			services.AddMediatR(typeof(GetAllAnimalsHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetAnimalIdHandler).GetTypeInfo().Assembly);

            // Comment Handlers
            services.AddMediatR(typeof(CreateCommentHandler).GetTypeInfo().Assembly);
			services.AddMediatR(typeof(GetAllCommentsHandler).GetTypeInfo().Assembly);
		}
		private static void ConfigureRepositories(IServiceCollection services)
		{
			services.AddTransient<IAnimalRepository, AnimalRepository>();
			services.AddTransient<ICategoryRepository, CategoryRepository>();
			services.AddTransient<ICommentRepository, CommentRepository>();
		}
	}
}
