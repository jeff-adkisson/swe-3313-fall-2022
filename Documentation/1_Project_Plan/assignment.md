**PROJECT PLAN**

Your team's project plan gives a high level overview of the scope of the project, the team performing the work, the schedule the work will be performed, an high level overview of the technical aspects of the system (including the data you expect to work with), and how you will test the system to ensure completeness and accuracy.

In the industry, the project plan is often used to bid on a project. You meet with a prospective client, get an idea of the effort, then write up a proposed plan to accomplish the project. Therefore, this document needs to be very polished - both content and format need to be very professional, finished, and well-organized.

You already have a detailed introduction to the project in Project | Coffee Company POS | Introduction. Read this document \*carefully\*. You should also ask your customer (me) any questions you have. Remember - requirements elicitation is your responsibility. Your customer often has expectations that were poorly (or not at all) communicated.  [https://kennesaw.view.usg.edu/d2l/le/content/2671534/viewContent/42631700/View?ou=2671534](https://kennesaw.view.usg.edu/d2l/le/content/2671534/viewContent/42631700/View?ou=2671534) 

You also have the base project now. I highly recommend that you review the code as well as it gives you some insight into my expectations (well-organized, commented code, follows the conventions I already set, etc.).  
[https://github.com/jeff-adkisson/swe\_3313\_fall\_2022/tree/main/Source](https://github.com/jeff-adkisson/swe_3313_fall_2022/tree/main/Source)

[There is an example plan from a prior semester here to show you an example of what I am expecting.](https://kennesaw.view.usg.edu/d2l/common/dialogs/quickLink/quickLink.d2l?ou=2671534&type=content&rcode=usgq-27839566) _Do **not** copy this example plan! Do your own work!_ 

Your plan will have 6 sections (plus a cover page and table of contents):

**1\. High Level Project Scope**  
   - High level description of what the project will accomplish.  
   - What will the system do? What problem does it solve?  
   - What can the client expect at the end of the project?  
   - If necessary, call out what the system will NOT do to avoid any assumptions, such as "This project will not include any mobile or web-based  functionality."  
   - Do not increase the scope by introducing new functionality. Do not omit anything either.  
     
**2\. Schedule (including work breakdown structure, milestones and/or deliverables, and a Gantt chart)**  
   - [Use the assignment schedule from D2L for the milestone dates.](https://kennesaw.view.usg.edu/d2l/common/dialogs/quickLink/quickLink.d2l?ou=2671534&type=content&rcode=usgq-26739522)  
   - For each milestone, show the work breakdown. Do not just include a single point such as "Nov 7, Technical Design Due". Provide the details you think go into each step, who will do each piece, and the order in which each line in the schedule will be performed.

**3\. Team organization (including resumes of the team members)**  
   - One page describing your overall organization  
   - One page for each team member's resume

**4\. Technical description of the system**  
   - What platforms will the system run on, OS requirements, storage requirements, etc.

**5\. Data management plan**  
   - How is data going to be stored?  
   - You have three types of data: configuration, customers (including order history), and menu items (including the customizations you can do to each menu item).  
     + What types of data will we find in each type?  
     + How are the types read/written?  
     + What does the application read/write vs just read?  
   - You are working with financial data. How are you going to handle that correctly?

**6\. Test plan**  
   - How will you ensure all requirements are met?  
   - How will you ensure all of the application's functionality works properly?  
   - Will you do any automated unit testing?  
     
**SUBMISSION REQUIREMENTS**

1) Produce an outstanding project plan in Word or Google Docs.

2) Export the plan to a PDF file.

3) Each \*team\* will fork the git repo at [https://github.com/jeff-adkisson/swe\_3313\_fall\_2022](https://github.com/jeff-adkisson/swe_3313_fall_2022). Each person does not need to fork - there should be one "official\* repo for each team forked off of the base repo.

4) When your project plan PDF is ready, add a folder to your team repo's Documentation folder named 1\_Project\_Plan and place the PDF in it. Name the file "coffee-project-plan.pdf". Commit the file to your team git repo.

5) Make sure your team's git repo is \*public\* so I can access it.

6) EACH member of the team will post the git repo's URL to the assignment folder (EVERYONE must do this). Even though you only have ONE team repo, every member of the team will post the assignment submission. If your teammates post their work and you do not, you will not receive a grade. Your submission should be:  
   1) Team Name  
   2) Your Name  
   3) Link to your team's git repo.  
     
7) Everyone on the team will receive the same grade for the project (unless you forget to submit your individual assignment requirements or you do not participant - see #6 and #8).

8) If anyone is not participating in the project, see me immediately. I will handle this on a case-by-case basis. It's possible certain people will help more with one aspect of the project than another, so try to work this out yourselves before involving me. Remember - I am your customer, so getting me involved in managing team problems before attempting to solve them yourself does not look professional. You need to think of yourselves as paid, professional software engineers - not bickering students - so approach this project professionally.

\----------------------------

**GRADING RUBRIC**

10% - Professional, well-organized presentation (there better not be any spelling issues or bad grammar!)  
      - Consider a cover page, table of contents, etc. Add page numbering, footers, etc. Do all of the things your English teacher taught you about writing professionally.  
      - Past students who have done great on this bit went to the University's writing center for help.  
        
10% - Accurately followed the git submission guidelines. This should an easy, nearly free 10%. Since this is easy, you either get all 10% or none of it.

80% - About 13% per section (there will be 6 sections in document)  
      - Complete?  
      - Clearly written?  
      - Thoughtful?  
      - In scope (don't go scope creeping this project!)  
      - Achievable?  
      - Demonstrates you have carefully considered the lectures we have done to this point.