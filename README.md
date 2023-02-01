# Sparkfish Exercise

the following project contains a 

## Running the test

Load the project into visual studio, right click on project within the Solution Explorer and select Run Tests


# Interview Questions

```diff
- text in red
+ text in green
! text in orange
# text in gray
@@ text in purple (and bold)@@
```

1. What are examples of the types of projects you have deployed to Azure? 
```diff
+ An Azure function written in Java deployed via GitHub action
+ An Azure web app written in .NET Core deployed via Octopus, then manually hot swapped via slots
```

2. How do you classify your senior-ness as a developer? What are your development strengths? 
```diff
+ I have many years writing code in the big two languages; C# and Java. I have held architect positions in both .NET and Java environments. When I approach a task, I don't just see the code, I mentally view how this piece of code fits in to the big picture and how this code can be tested.
```

3. What are your top 1-2 favorite editor(s)? 
```diff
+ Eclipse (Java) 
+ Visual Code (Node/Typescript, C#)
```

4. Have you ever done a pull request? 
* I have done hundreds of pull requests

5. Have you ever had a chance to use TDD? Have you found it to be helpful? If so, when does it work best for you? 
* I am a BDD Evangelist. As you might know, BDD is an evolution of TDD. One of the first things I ask when new code is brought in or discussed during a standup is "How will you test that?" I noticed in your exercise you referenced BDD with your Given/When/Then

6. Have you been given the opportunity to use tools like ReSharper? What did you like about it?
* I am a Resharper baby, meaning I feel lost if I hop on a machine that doesn't have Resharper installed

7. Do you prefer working directly with the business people? Or do you find it's best to have a go-between?
* I am very flexible and enjoy different environments, for example, one week I meet with customers then the next week I'm in the weeds with the devs

8. Have you ever used web.config transformations? If not, do you know what they are good for?
* I have never used web.config for transformations so I had to Google and I see how that could be useful during deployments

9. Can you tell me anything about `slots` in terms of Azure? If not, based on what you just googled, how would you use them in your next Azure project?
* Yes, the first question above I talk about using deploymnent slots in Azure. So we deployed to a slot, then perform a final smoke test on the slots, then we would perform a swap

10. Can you explain what DevOps and/or continuous integration is, and some of the benefits?
* These days it seems CICD go together seemlessly, you dont have one without the other. My last position I handled the CICD for our team. This was a Java environment writing Azure Functions comitting to GitHub. The GitHub actions would fire off and handle the deployment to Azure. This encompassed a few things out of my perview, like KeyVaults and IP Assignement but writing bicep files for APIM access and Resource Group creation were just a few of the CICD tasks I was responsible for

11. Are you technology agnostic or are you pretty strict when it comes to things like Mac vs Windows, or AWS vs Azure?
* I am a Windows guy but enjoy both AWS and Azure work. I prefer AWS because of its simplicity but have more experience in Azure

12. What are some of your more advanced SQL querying abilities (i.e., like what keywords or commands, etc)?
* I am familiar with the basics of SQL Statements in addition to JOINs, inner and outer, these would be on the forefront of my mind. Anything more complex than that I would use ChatGPT or Google to help or if there is a DBA, I tend to keep things in a group as tribal knowledge can be key at times

13. Do you happen to know what TypeScript is and why it’s gotten popular? How does it differ from JS?
* About 4 years ago I was getting bored with programming but luckily node.js came out and Typescript, once I learned those two items, programming was fun again. So, yes I am a huge fan of Typescript mainly due to its strongly typed capabilities
 
14. Can you explain the diff b/t relational databases and NoSQL? What are some NoSQL platforms that you have familiarity with?
* Relational databases establish logical connections (i.e. relationships) between domain objects (ex: Customer -> Address) where NoSQL would just contain single documents (i.e. Tables) that store "blobs" of Customers and/or Addresses. My work in the past has been to use NoSQL for quick application access and eventually that NoSQL data would end up in a relational database after a batch process

15. Can you explain GPG, SSL or public/private key encryption?
* I Googled GPG and see that it is a way to encrypt files, I have never used this. SSL deals with certificates, both Java and .NET web based programs would have an SSL certificate installed on a client computer and another practice it to install a certificate in a local Java keystore

16. Do you know anything about "secure coding" practices?
* I have used tools like OWASP for penetration testing, then based on the report, went back and fixed the recommendations. I tend to remember what I changes and then make that fix part of my everyday coding practices

17. Can _you_ authenticate to GitHub using SSH?
* Yes, we can connect to GitHub using SSH but this is something I have not done

18. Can you explain what REST sorta kinda means?
* Rest is a way to expose access to ones backend domain via http. The protocols are GET, POST, PATCH, DELETE and PUT. One can reuse a Rest Api Uri by simply annotating the method in a controller with the respective Http Protocol. For example, the URI /listify, can exist for all protocols

19. How enthusiastic would you be if we asked to pay you to take some training courses on Udemy?
* I am a huge advocate and consumer of both Udemy and Pluralsoft and would take any class you assign

20. How many of these platforms / languages / frameworks do you have experience with? 
Node, Typescript, React, SQL, Excel, Windows, Docker, Kubernetes (I'm lite on this), .NET, C#, NUnit, JUnit, Go (I took a UDemy class on Go), PostgreSQL, MySQL, SQL Server, MongoDB, Azure, AWS
