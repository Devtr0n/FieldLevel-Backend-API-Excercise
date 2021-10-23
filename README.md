# Project Description

This project is about exposing a single web api endpoint that returns the most recent post authored by each user from a third party data set.

## Requirements
- You can choose ASP.NET or .NET Core, please let us know if you choose .NET core so we can change the environment on azure so auto deploys will work as you push code to the master branch.

- Call your project Fieldlevel so that end up with a FieldLevel.csproj
- The data set is located here https://jsonplaceholder.typicode.com/posts
- Results should display the most recent post authored by each user. Use post.id to determine recency.
- Regardless of the frequency at which your endpoint is requested across multi devices, the third party data set should not be requested more than once per minute.
- Due to the simplicity of this test, you'll also be evaluated based on thoroughness and thoughtfulness of your solution. 
- Code the exercise as if you were doing this at a job.
- Please do not spend more than a 4 hours on this task.

## Deliverables

- Please provide a single solution file (\*.sln) that can be compiled and launched from Visual Studio.
- import the exercise repository to your personal Github account using [github's import tool](https://github.com/new/import) import this url: https://github.com/FieldLevel/exercise-backend-api
- complete the exercise
- invite our github user "fl-codereview" to be a collaborator on the repository
- create a pull request against your Github repository
- let us(your interview coordinator) know when you are ready to review


# How To Run

- Open the solution in Visual Studio
- Press F5 to start debugging

# Deployment
This will be auto deployed to an azure site
https://{git-repo}.azurewebsites.net

Customizing
https://github.com/projectkudu/kudu/wiki/Customizing-deployments

# FAQ

Q: **Why aren't there any unit tests or integration tests?? I thought you loved xUnit?**

A: Time constraints. 

Q: **Why is Swagger / Open API documentation missing?**

A: Again, time constraints. 

Q: **Would you really use a DateTime type and the .Subract() method to limit access to the third party data (example JSON)?**

A: Of course not. Time constraints. 

Q: **Where are the comments?**

A: Once again, time constraints. The code is fairly straightforward and simple enough.

Q: **Why did you choose .NET 5 and not .NET 6?**

A: I haven't installed .NET 6 yet, but have been keeping up via Youtube and Microsoft's videos.

Q: **Why did you complete this project on a Friday night, you don't even live in our time zone?**

A: It looked like fun and I was bored?

## Contact ##

You can contact me <a href="mailto:richardsmailbox@gmail.com?subject=Getting in touch!&body=Hi, I would like to contact you, Devtr0n.">via gmail</a> or at my website http://www.richardhollon.com (I wrote it in ReactJS/NPM) or find me on <a href="https://www.linkedin.com/in/richardhollon/" target="_blank"><img alt="LinkedIn" src="https://img.shields.io/badge/linkedin-%230077B5.svg?style=for-the-badge&logo=linkedin&logoColor=white"/></a>
 
<p align="left">
  <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white"/>
  <img alt=".Net" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white"/>
  <img alt="Visual Studio" src="https://img.shields.io/badge/VisualStudio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white"/>
  <img alt="GitHub" src="https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white"/>
  <img alt=".NET Core" src="https://img.shields.io/badge/-.NET Core-orange"/>
</p>
