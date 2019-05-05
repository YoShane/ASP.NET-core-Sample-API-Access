# Sample API Access
<br>
<b>Provides a simple API access site example</b>

<h3>Description of transformation process</h3>
> 1.  Follow the instruction to set up and use Scaffold until Initial migration.<br>
> 2.  Change database Settings(appsettings.json)<br>
> 4.  Do initial migration.<br>
> 3.  Make sure the current version of EF core works.<br><br>
  ----------transformation process start-----------<br>
> 4.  Delete all EF core libraries.<br>
> 5.  Delete Data/MvcMovieContext<br>
> 6.  Deletes a database that exists table -EFMigrationsHistory<br>
> 7.  Start making changes one by one(Compare my code),it's only change Startup,ShopsController,SeedData<br>
> 8.  Done. Good luck!
