# Emenu.Productmanagement

## About this solution

### Pre-requirements

* [.NET 8.0+ SDK](https://dotnet.microsoft.com/download/dotnet)
* [Node v18 or 20](https://nodejs.org/en)

### Configurations

The solution comes with a default configuration that works out of the box. However, you may consider to change the following configuration before running your solution:

* Check the `ConnectionStrings` in `appsettings.json` files under the `Emenu.Productmanagement.Web` and `Emenu.Productmanagement.DbMigrator` projects and change it if you need.
* Check the appsetting file under `Emenu.Productmanagement.Application` and add the Cloudinary Setting.
### Deploying the Application

Deploying an ABP application is not different than deploying any .NET or ASP.NET Core application. However, there are some topics that you should care about when you are deploying your applications. You can check ABP's [Deployment documentation](https://docs.abp.io/en/abp/latest/Deployment/Index) before deploying your application.

* Run `abp install-libs` command on your solution folder to install client-side package dependencies. This step is automatically done when you create a new solution with ABP CLI. However, you should run it yourself if you have first cloned this solution from your source control, or added a new client-side package dependency to your solution.
* Run `Emenu.Productmanagement.DbMigrator` to create the initial database. This should be done in the first run. It is also needed if a new database migration is added to the solution later.
* Run `Emenu.Productmanagement.Web` and visit URL 'https://localhost:44365/swagger/index.html' to test.