# ASPNET5 MVC6 Integration Tests
This repo shows how to write integration tests for an ASPNET5 MVC6 RC1 project using [xUnit](http://xunit.github.io) and the [Microsoft.AspNet.TestHost](https://github.com/aspnet/Hosting).

## Fixing the missing view problem
Thanks to [David Fowler](https://github.com/davidfowl) for this [Pull Request](https://github.com/mattridgway/ASPNET5-MVC6-Integration-Tests/pull/1) which shows how to setup your project to avoid a known problem where integration tests hosted in a separate project which uses the Microsoft.AspNet.TestHost will fail with the error:

```
System.InvalidOperationException : The view ‘Index’ was not found. The following locations were searched:
 /Views/Home/Index.cshtml
 /Views/Shared/Index.cshtml
```

This has been seen in a few places:
* http://stackoverflow.com/questions/34590142/placing-asp-net-5-tests-in-separate-assembly
* http://dotnetliberty.com/index.php/2015/12/31/fast-asp-net-5-integration-testing-with-xunit/
* http://brockallen.com/2016/01/01/browsr-helper-for-integration-testing-in-asp-net-5/
