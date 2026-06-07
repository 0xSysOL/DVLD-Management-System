# 📑 DVLD - Driving and Vehicle License Department System

An educational project (not a commercial product) aimed at simulating a government system to manage the lifecycle of driving licenses, from application submission to license issuance, including tests and fines.

This is my first large-scale software project. It was built from Jan 7, 2026, to June 2026. The main goal was to learn and apply what I studied in the DVLD course step-by-step, attempting to understand the "why" before the "how".

## 🧠 Why is this project important to me?

* It is the first time I have written a system of this size (thousands of lines, dozens of screens).
* I learned how to organize code into layers (UI, Business, Data).
* I encountered real database problems and complex table relationships, and I tried to solve them on my own.

## 🗄️ Key Learning: Managing Transactions (SqlTransaction)

In this project, I faced a challenge: what if the data saving process fails halfway through?

For example, when booking a license and imposing a fine, the process must either complete fully or not happen at all. If any part fails, the system must revert all changes.

My instructor did not explain this point in Previous courses, but it was essential for the program's logic. Therefore, I researched it myself, learned `SqlTransaction`, and implemented it in the system.

Now, financial and administrative operations (booking, unbooking, issuing a license) are all protected within a transaction. If an error occurs, it rolls back automatically.

## 🧱 Project Structure

* **Data Layer:** SQL queries, stored procedures, and table-valued functions.
* **Business Layer:** Business rules, data validation, three tier architecture.
* **UI Layer:** Windows Forms with reusable controls.

## 📚 Lessons Learned

* Writing complex SQL queries (LEFT JOIN, Subqueries, TVFs).
* Understanding the practical difference between INNER JOIN and LEFT JOIN.
* Managing request states (New, Cancelled, Completed).
* The importance of data validation across multiple layers.
* Handling errors and edge cases.
* And most importantly: Patience. Some problems took hours of thinking, but they were worth it.


## 📸 Screenshots

![Log In](![Login Screen](Image/Log%20in.PNG)
![Main Screen](Image/Main.PNG)
![People Management](Image/People.PNG)
![Users Management](Image/Users.PNG)
![Drivers Management](Image/Drivers.PNG)

## 📌 Final Note

This project is not perfect, and it is not a competitor to commercial systems. It is a first step in a long journey. However, I am proud of it because it represents everything I learned during these months.
