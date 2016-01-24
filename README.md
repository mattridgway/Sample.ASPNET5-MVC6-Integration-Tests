# Failing Tests
When writing an integration test for an ASPNET 5 MVC project which uses Microsoft.AspNet.TestHost, if the integration test is in a separate project to the MVC site, the test will fail with the error:

```
System.InvalidOperationException : The view ‘Index’ was not found. The following locations were searched:
 /Views/Home/Index.cshtml
 /Views/Shared/Index.cshtml
```

When running the site in IIS Express or Kestrel it works fine, and the test passes if written in the same project as the MVC site.
It would appear other people have had similar issues (reading the comments):
 - http://stackoverflow.com/questions/34590142/placing-asp-net-5-tests-in-separate-assembly
 - http://dotnetliberty.com/index.php/2015/12/31/fast-asp-net-5-integration-testing-with-xunit/
 - http://brockallen.com/2016/01/01/browsr-helper-for-integration-testing-in-asp-net-5/

## Setup
 - Visual Studio 2015 Community
 - 2 x Blank ASPNET 5 RC1 project
 - xunit 2.1.0
 - xunit.runner.dnx 2.1.0-rc1-build204
 - Microsoft.AspNet.TestHost 1.0.0-rc1-final
 - Microsoft.AspNet.Mvc 6.0.0-rc1-final
