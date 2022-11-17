**Please submit a single PDF that contains your team's Technical Design document.** 

Technical Design tells your developers exactly how to implement the system. You can assume they will read the requirements, but you need to document the non-functional parts here such as how to read/write to the JSON "database" and any other parts a developer may not have enough information to unambiguously implement your project.

It is vital that all of the designs in this document are consistent with one-another. You are representing data and classes in a variety of ways (JSON, ERD, UML classes), but all of them should relate to one another with the same labels, etc.

**1. Your technical design submission will have 3 sections:**

- **Section 1: JSON Example for Customer data**

  Your customer JSON file will contain customer data (including the Anonymous customer). It will also include sales history under each customer. Design an example Customer JSON file and document each field. I recommend starting here with this project. It will help you understand what you must include in your class diagram and your ERD diagram.

  [As a reminder, you should review the project introduction. It gives you very specific information about how the customer data will be stored.]()

  This section will include *two* components:

  **Section 1A) EXAMPLE CUSTOMER JSON FILE**
  \- An example Customer JSON using proper JSON notation.[ I will load your JSON into a validation tool to check the syntax.](https://www.online-json.com/json-validator) The JSON file must extend [the Customers.json file in the source project](https://github.com/jeff-adkisson/swe_3313_fall_2022/blob/main/Source/CoffeePointOfSale/JsonStorage/Customers.json). This file should be 100% consistent with the customer data in your ERD file.
   \+ Make sure the file has at least 3 customers (in addition to the Anonymous customer)
   \+ Customer 1 must have no orders.
   \+ Customer 2 must have one order. The order should have at least two drinks, each with one or more customizations.
   \+ Customer 3 must have two orders. Each order should have at least two drinks, each with one or more customizations.

  **Section 1B) CUSTOMER JSON FILE DATA DESCRIPTION**
  \- Create a table with a description of each field in the Customer JSON file. The table must include:
   \+ Path to the field (mirrors JSON structure). For example, *Customers.[key].Phone*.
   \+ C# data type of field. For example, *string*.
   \+ Short description of the field. For example, *Contains phone number of customer. Note that the Anonymous customer has anonymous in this field. Otherwise, you can expect a well-formatted phone number.*

  [NOTE: DrinkMenu.json is complete. You do not need to do anything to that file.](https://github.com/jeff-adkisson/swe_3313_fall_2022/blob/main/Source/CoffeePointOfSale/JsonStorage/DrinkMenu.json) You might wish to review it, however.

  

- **Section 2: UML Class Design diagram**
  *See How to Draw Your UML Class Diagrams below for more details.
  *
  [Refer to the CoffeePointOfSale solution I provided in the base github project](https://github.com/jeff-adkisson/swe_3313_fall_2022/tree/main/Source/CoffeePointOfSale). You must include the following three main areas represented in the base project:
  \- **Forms** (existing, base *and* the forms you intend to implement.
  \- **Services** - Customer, DrinkMenu, and CsvExtract. Customer is mostly done (you must extended it). DrinkMenu is not done and requires design. Use Customer for inspiration and *I highly recommend* reviewing the[ MVC Coffee lecture demo](https://github.com/jeff-adkisson/swe_3313_fall_2022/tree/main/LectureDemos/Mvc_Coffee) for some inspiration on DrinkMenu and CsvExtract.
  \- **Configuration** - Most of this is already present in the project. Model it appropriately in UML.

  All classes must show their *public* methods and properties (remember - anything in an interface is inherently public). [Don't forget to use proper notation for public access.](https://www.uml-diagrams.org/visibility.html)

  Notes: 
  \- Do not limit your diagram to what is in the source project - you received that as a base to get you started. You must show all of the existing *and new form and service* classes using proper symbols, arrows, etc.
  \- Your UML class diagram *must be consistent* with your example customer JSON file and your ERD diagram. In other words, If your class design works with data not in the ERD, you likely have a problem. 
  \- HINT:[ Convert your Customer.json to C#](https://json2csharp.com/), then draw the UML related to the Customer classes that goes in Services.Customer.

  

- **Section 3: Crows Foot ERD Data Model diagram**
  *See How to Draw your ERD Diagrams using the Crows Foot Model for more details.

  *Your Crows Foot ERD diagram must include:
  \- the Customer data model including how sales data will be related to Customers. Make sure all data related to customers and sales are properly models using Crows Foot notation. Sales data storage is not in the base project, so that is an area of design where you will be doing new design work - not just representing what I already provided. 
  \- the Drink Menu data model showing how drinks and customizations are stored.

  Notes:
  \- To help verify your ERD is complete, review your UI design project. Is there data in your UI design that is missing from your ERC?
  \- Does your ERD have everything from your example Customer.json file?
  \- Your ERD diagram *must be consistent* with your example customer JSON file and UML Class Design. In other words, If your class design works with data not found in the ERD (or derived from, at a minimum), you likely have a problem.

**2. JSON Tools**

\- [Base customer JSON file](https://github.com/jeff-adkisson/swe_3313_fall_2022/blob/main/Source/CoffeePointOfSale/JsonStorage/Customers.json) 
\- [Completed DrinkMenu JSON file](https://github.com/jeff-adkisson/swe_3313_fall_2022/blob/main/Source/CoffeePointOfSale/JsonStorage/DrinkMenu.json)
**-** [JSON Validator](https://www.online-json.com/json-validator)
-[ JSON to C# converter](https://json2csharp.com/)

**3. How to Draw Your UML Class Diagrams**

Draw your use case diagrams in Dia http://dia-installer.de/ or [PlantUML](https://plantuml.com/class-diagram) (highly recommended!). You can use something different if you don't like Dia or PlantUML, but you *must* use UML standard class design symbols - do not try to do this in PowerPoint and definitely do not draw it freehand. Dia is free, cross-platform, easy to use, and produces good results. Do not draw your diagrams on paper and take pictures - your diagrams must look great, follow the correct symbol and arrow vocabulary, and be a great way to guide your developers to accurately perform class implementation, relationships between data classes, etc. Your team will not be happy with the assignment grade if the UML class diagrams do not look good.

**4. How to Draw your ERD Diagrams using the [Crows Foot Model](https://www.relationaldbdesign.com/database-design/module7/three-model-types.php)**

Draw your ERD diagrams in Dia http://dia-installer.de/ or [PlantUML](https://plantuml.com/class-diagram). You can use something different if you don't like Dia or PlantUML, but you *must* use UML standard ERD crows foot symbols - do not try to do this in PowerPoint and definitely do not draw it freehand. Dia is free, cross-platform, easy to use, and produces good results. Do not draw your diagrams on paper and take pictures - your diagrams must look great, follow the correct symbol and arrow vocabulary, and be a great way to guide your developers to accurately perform class implementation, relationships between data classes, etc. Your team will not be happy with the assignment grade if the UML class diagrams do not look good.

Be sure to use the [Crows Foot Model - *not* the Chen](https://www.relationaldbdesign.com/database-design/module7/three-model-types.php) model or other types. An example of a Crows Foot Model is here. You will note it looks much like a class diagram but uses specific arrow types to indicate multiplicity. 

![img](https://www.ermodelexample.com/wp-content/uploads/2019/10/erd-crows-foot-relationship-symbols-cheat-sheet-crows-regarding-er-diagram-crows-foot.png)

**5. Professional Presentation Requirement**

Obviously, your diagrams need to exhibit excellent grammar, spelling, formatting, etc. Make your English teacher proud here. Page numbers, headings, etc. All of that matters here. When a customer is paying for something and they get a document back that looks like you wrote it 5 minutes before the meeting, your reputation suffers and the customer is more likely to fire you.

Diagrams must be high-resolution to support zooming. Your diagrams should maximize the page layout, so if your diagrams have landscape orientation, configure the page as landscape.

**6. Submission Requirements**

Compile everything into a single high-resolution PDF. If your diagrams are in landscape format (wider than tall), then set the page configuration to landscape to make your diagrams larger on screen. 

*Ensure your diagrams are high-resolution so I can zoom into them without difficulty reading the various labels, etc.*

Add your PDF to your shared team repository in the Documentation/4_Technical_Design folder. Call your file "coffee-project-requirements.pdf". Each team member will submit your team repo link in the D2L assignment folder. As before, everyone on the team will receive the same grade. The only exception is if an individual forgets to do their individual submission in D2L. 

\---------------------------

**Example Submission**

I am not providing a prior s**e**mester example for this. I have modified the project significantly from prior semesters for this part in particular and an example from that material would probably hurt more than help. 

Besides, at this point, you know my expectation - detailed, thoughful design, professional presentation and internally consistent material.

\---------------------------

**GRADING RUBRIC**


10% - Professional, well-organized presentation (there better not be any spelling issues or bad grammar!)
   \- Consider a cover page, table of contents, etc. Add page numbering, footers, etc. Do all of the things your English teacher taught you about writing professionally.
   \- Diagrams must be high-resolution to support zooming. Your diagrams should maximize the page layout, so if your diagrams have landscape orientation, configure the page as landscape.

30% - Customer.json Example File (with sales history data) and data field description table
  \- Contains required example data.
  \- Extends the base Customers.json file you received in your base project.
  \- Contains required example data.
  \- [Example file is valid, well-formed JSON](https://www.online-json.com/json-validator). 
  \- Data field table contains all fields in the file, are well documented, and use appropriate data types.
  \- Data is structured [as described in the project introduction.]()

30% - UML Class Diagram(s)
  \- Extends the [base project](https://github.com/jeff-adkisson/swe_3313_fall_2022/tree/main/Source) in the areas described above (all existing and new forms, services, etc.
  \- Uses proper UML class design notation, including inheritance relationships and proper arrow types/direction.
  \- Is consistent with your Customer.json file and ERD diagram.
  \- At a minimum, covers all forms, services, and configuration classes (including interfaces, base/abstract classes, etc.)

30% - ERD Crows Foot Diagram(s)
  \- Properly models the storage of customer, sales, and drink menu data. All data and relationships stored in the JSON files your project will use must be present.
  \- Is consistent with your Customer.json file and UML class diagram.
  \- Uses proper Crows Foot ERD notation. Properly demonstrates multiplicity between entities. 