
# UI Prototype
To access the UI prototype, use the following link:
[Marvel Prototype](https://marvelapp.com/prototype/82jeda9/screen/89285369 "Marvel Prototype")

You will create a [high-fidelity prototype](https://blog.prototypr.io/high-fidelity-prototyping-what-when-why-and-how-f5bbde6a7fd4) for the UI of the Coffee Shop application *and* record a short presentation to your customer demonstrating the prototype.

## HIGH-FIDELITY PROTOTYPE:

Your prototype must include every screen that any of the users would be able to access. The purpose of this prototype to explore the graphic design of your final implementation. Layout screens as you plan for them to appear in your final implementation. Make informed choices about colors, fonts, alignment, icons.

You will create your screens using Microsoft PowerPoint *or* Marvel (one or the other - *not both*). 

1. [PowerPoint is the minimum acceptable tool for this project.](https://keynotopia.com/guides-ppt/) All of you have it as part of your Office 365 university account.
2. [Marvel is the *recommended* tool for this project. ](https://marvelapp.com/)You will have to take the time to learn Marvel - I cannot cover it in class. Marvel is what Professor Sandra Jones uses in her design classes. It is friendly, and easy to learn. You can create a free Marvel account for your prototype. Choose the **Website/TV** project type to most closely simulate the size of our desktop application.

**If your team uses Marvel, I will add 5% to your submission score as a bonus for going above and beyond the minimum submission requirement.**

Why use Marvel? PowerPoint is *not* an outstanding tool for this project. This is not a dedicated UI design class, so I cannot spend time teaching you to use a tool like Marvel. That said, I *highly* recommend you spend the extra time doing this because we need to make this experience as close to what you do in real, professional practice as possible. PowerPoint is *acceptable*, but it's not a great tool for professional UI design.

## PROTOTYPE PRESENTATION MP4 RECORDING:

After creating your prototype, you will record a 5 minute MP4 video demonstrating the prototype. Your goal is to make sure your customer understands approximately how the application will look, perform different flows, number of actions to complete an operation, etc.

## HIGH-FIDELITY UI PROTOTYPE REQUIREMENTS:

\1. Include every screen you described in your Project Plan and Requirements documents. Remember not to increase scope by adding elements to your UI that you did not commit to your customer in your prior work. Here are the seven screens from the Introduction document.

  **A) Main screen**
    \- Large buttons to go to Order Drink (for anonymous customers who do not wish to participant in
    Rewards), Customer List, and Management Tools

  **B) Customer List screen**
    \- Sorted by last name, then first name, then phone number. The *anonymous* customer should
    always be at the top of the list.
    \- Includes number of reward points
    \- Includes button to add a new customer
    \- Each customer has an Order Drink button that selects the customer and goes to the Order Drink screen.
    \- Include a button to return to the Main screen.

  **C) Add Customer Screen**
    \- Enter First Name, Last Name, Phone Number. All fields are required.
    \- After adding a new customer, go directly to the Order Drink button.
    \- Cancelling adding a new customer goes back to the Main screen.
  
  **D) Order Drink Screen**
    \- If coming directly from Main screen | Order Drink, the Customer is *anonymous*.
    \- Customer can order one or more drinks.
    \- Each drink can be customized. Customizations affect the price.
    \- This screen will have two panes:
      \+ Left side: drink creator
      \+ Right side: drinks added to the order, plus subtotal, tax, and total.
    \- Once there is at least one order, activate the button to go to Payment screen.
    \- Cancelling the order goes back to the Main screen.

  **E) Payment Screen**
    \- Customer can pay with a credit card or reward points (anonymous customer cannot use rewards)
    \- Go to Receipt screen after successful payment.
    \- Cancelling the order goes back to the Main screen.

  **F) Receipt Screen**
    \- Shows the drink(s) the customer ordered (including customizations), prices and quantities, subtotal,
  tax, and total.
    \- Shows payment method - last 4 digits of credit card or number of Reward points redeemed
    \- Shows remaining Reward points *if* customer is not *anonymous*.
    \- From the Receipt, return to the Main screen. You cannot cancel the order once a receipt is present.

  **G) Management Screen**
    \- Include a button to generate a CSV sales report.
      \+ When clicked, generate a CSV file of all sales, and open the file in Excel. Use screenshots of Excel with some fake sales data.
    \- Include a button to return to the Main screen.

\2. You must link every clickable action to demonstrate how the user will flow through the application.

\3. You must demonstrate these seven end-to-end flows through the application:

  A) Anonymous user flow from Main screen through payment.

  B) Existing customer user flow (Main to Customer List to select existing customer, etc.)

  C) New customer user flow (Main to Customer List to Add Customer, etc.)

  D) Adding a drink to an order and choosing one or more customizations.

  E) Paying with reward points flow including the receipt.

  F) Paying with credit card flow including the receipt.

  G) Generating CSV sales report and opening it in Excel. Use screenshots of Excel with some fake sales data.
  
  Each flow must be linked in PowerPoint or Marvel so the prototype demonstration can be clicked through.

  \+ PowerPoint links: https://support.microsoft.com/en-us/office/add-commands-to-your-presentation-with-action-buttons-7db2c0f8-5424-4780-93cb-8ac2b6b5f6ce

  \+ Marvel links: https://help.marvelapp.com/hc/en-us/articles/360002779318-How-to-link-screens-with-hotspots
  
\4. Navigation must be friendly, clear, and consistent. Use common terminology a coffee shop employee would understand. 

\5. Be consistent throughout. For example, do not say "Cancel" on one screen and "Stop" on another if both mean the same thing. Do not use red for "cancel", then blue for "cancel" on another page. Try to keep navigational controls in the same place on the screen. If you have warnings, error messages, etc., keep them consistently formatted and try to put them in a place the user will find them (how many times have you not been allowed to submit a form because an off-screen error message is hidden in a form somewhere - everyone hates that!).

\6. Try to minimize the clicks, typing, etc. the user must perform to complete each step in a flow. Your goal is to streamline coffee shop operations (which means faster service for customers, fewer repetitive motions for employees, etc.). But remember - do not streamline to the point that the UI isn't friendly and clear. Ask yourself if a new employee could do each operation with little or no training or expertise.

\7. Do not forget you are ultimately building a WinForms application - not a website or phone app. That means things must fit in the app window (you are not working in a browser). Do not show things in your prototype you cannot accomplish in a WinForms application. If your team has split coding and design responsibilities, be certain your designer and your coder agree what you are designing can be built. Your prototype must be achievable in code - what you are prototyping here will be compared to your final project during your end-of-semester presentation. Your WinForms application will have a screen size of 1348x721, so your prototype's proportions should approximate that (within the limits of PowerPoint or Marvel). Make sure your entire team agrees that your design can be built. Your customer is going to expect the final application to look much like your prototype.

 \- NOTE: The screen proportions are important because your customer may have specific hardware for their stores that will not permit just any screen size. That one reason why your application has this requirement (the other was so all of you have a consistent base project).

![img](/content/enforced2/2671534-CO.430.SWE3313.XLS.BBB.20232/PastedImage_2s541uj4dlx7j4yftc2ixhy013ylbghv001541974256.png)

\10. Only coffee shop employees are using this application - not customers. There are no self-service features in this application.

\11. There is no login screen or concept of manager vs non-manager.

## EXAMPLE PROTOTYPE FROM A PRIOR SEMESTER:

[Here is a Pizza Project UI example from a prior semester. ]()Note that this is *not* interactive (no links between screens) and does not have the same requirements as your project, so do not base your work on this example. It is provided to show you the level of thoughtful design, polish, and professional presentation a top submission will exhibit.

## PROTOTYPE PRESENTATION MP4 RECORDING REQUIREMENTS:

\1. Record your presentation and save it as an MP4 file. There are many ways to do this. You decide how you want to record the file.
  https://videoconverter.iskysoft.com/video-tips/top-mp4-recorder.html
  
\2. Demonstrate each of the seven flows listed in the UI PROTOTYPE REQUIREMENTS.

\3. Speak clearly and be very professional.

\4. Keep your presentation to 5 minutes or less.

## SUBMISSION REQUIREMENTS:

*Do one or the other - not both!*

### **POWERPOINT SUBMISSION:**

1. Create your PowerPoint high-fidelity UI prototype.
2. Add your high-fidelity PowerPoint UI prototype to your team's GitHub repo in the *Documentation\3_UI_Prototype* folder. Name the prototype **powerpoint_ui_prototype.pptx**.
3. Add your UI presentation MP4 video to your team's GitHub repo in the *Documentation\3_UI_Prototype* folder. Name the presentation **prototype_video_presentation.mp4.**
4. Verify you have met the submission requirements *exactly* to avoid penalties. Go to your GitHub repo and verify you can see the documents listed above.

### **MARVEL SUBMISSION:**

1. Create your Marvel high-fidelity UI prototype.
2. [Share your prototype. You will need a public link I can reach.](https://help.marvelapp.com/hc/en-us/articles/360003582958-How-to-share-your-prototype-by-SMS-email-or-via-link)
3. Create a [markdown file (.md) named **readme.md**](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax) in your team's GitHub repo in the *Documentation\3_UI_Prototype* folder. Include a public link I can use to view your Marvel prototype. Verify the link is public.
   *[See this example readme.md in my SWE repo if you want an example I created.](https://github.com/jeff-adkisson/swe_3313_fall_2022/tree/main/LectureDemos/DecisionTable_VisualStudio#readme)*
4. Add your UI presentation MP4 video to your team's GitHub repo in the *Documentation\3_UI_Prototype* folder. Name the presentation **prototype_video_presentation.mp4.**
5. Check in your readme.md to your team's shared GitHub repo. Verify you have met the submission requirements *exactly* to avoid penalties. Go to your GitHub repo and verify you can see the documents listed above.

## GRADING RUBRIC:

**40% - Screens from HIGH-FIDELITY UI PROTOTYPE REQUIREMENTS**
 All seven screens listed in the HIGH-FIDELITY UI PROTOTYPE REQUIREMENTS are designed, consistently presented, have realistic sample data, etc. All screens generally fit in the approximate proportions of the final application (1348x721).

**40% - Flows from HIGH-FIDELITY UI PROTOTYPE REQUIREMENTS**
 All seven flows listed in the HIGH-FIDELITY UI PROTOTYPE REQUIREMENTS are designed, linked together, have realistic sample data, etc.
  
**20% - Presentation from** **PROTOTYPE PRESENTATION MP4 RECORDING REQUIREMENTS**
  Presentation covers all flows and screens, is professionally presented, and is 5 minutes or less.

**5% - Bonus**
5% bonus if prototype was built using Marvel. There is no bonus if your prototype uses PowerPoint (that is the minimum acceptable submission format).
