<div align="center">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/c850325da277b398ab0c90cb89b98f0f4a4d21d9/Images/Logo.png" width="1000"/>

</div>

<hr style="height:3px;border:none;background-color:#6b21a8;">

<div align="left">

<img src="https://raw.githubusercontent.com/sushiGyuuuuu/iPocket-Final/c1acb70a4c9e4227f35faec36d75a4f733c658a9/Images/Description.png" width="280"/>

</div>

**iPocket** is a banking application designed to help users grow their savings through a progressive interest system. Unlike traditional savings accounts, the application increases the **interest rate by 1% each year**, rewarding users who keep their money in the system for a longer period of time.

In addition to its savings feature, iPocket also includes a **Send Money** function that allows users to transfer funds to other users within the platform.

The system addresses the common problem of low motivation to save by offering increasing rewards over time. It is designed for students, young professionals, and first-time savers who are looking for an easy, secure, and effective way to manage and grow their money.

<div align="center">

<em>Because your money deserves a raise!</em>

</div>

<hr style="height:3px;border:none;background-color:#6b21a8;">

<div align="left">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/cb2b53a7c2b070ef5951ba3e9d91f59dccebc678/Images/UML.png?raw=true" width="280"/>

<div align="center">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/bf2da670408cfa75aa39fa386c21892767ccafd8/Images/UML%20Pt.%202.jpeg?raw=true" width="500"/>

</div>

<br>

<hr style="height:3px;border:none;background-color:#6b21a8;">

<div align="left">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/64ab7aa915ac09d2d85b6e58bfed60f685ecb4ae/Images/Features%20and%20Functionalities.png?raw=true" width="490"/>

</div>

<table>
  <tr>
    <th>Feature</th>
    <th>Description</th>
  </tr>

  <tr>
    <td><b>Authentication System</b></td>
    <td>Users can create an account and securely log in to access the system and its features.</td>
  </tr>

  <tr>
    <td><b>Dashboard Management</b></td>
    <td>The dashboard provides an overview of the user’s current balance, quick access to system functions, and recent transaction activities.</td>
  </tr>

  <tr>
    <td><b>Deposit and Savings System</b></td>
    <td>Users can deposit money into their account and save funds securely within the system.</td>
  </tr>

  <tr>
    <td><b>Progressive Interest Rate</b></td>
    <td>The system applies an annual interest rate that increases by 1% every year to encourage long-term saving habits.</td>
  </tr>

  <tr>
    <td><b>Automatic Interest Calculation</b></td>
    <td>Savings balances are automatically updated by the system without requiring manual computation from the user.</td>
  </tr>

  <tr>
    <td><b>Savings Growth Tracker (Jar of Joy)</b></td>
    <td>Users can monitor the growth of their savings over time through a visual and interactive savings tracker.</td>
  </tr>

  <tr>
    <td><b>Send Money Feature</b></td>
    <td>The system allows users to transfer funds to another account while validating available balance before processing transactions.</td>
  </tr>

  <tr>
    <td><b>Transaction History</b></td>
    <td>Users can view recent deposits, transfers, and other transaction records for monitoring purposes.</td>
  </tr>

  <tr>
    <td><b>Identity Verification</b></td>
    <td>Users can select an ID category and upload a valid identification card for account verification.</td>
  </tr>

  <tr>
    <td><b>Profile Management</b></td>
    <td>Users can view and update their profile information and manage account-related settings.</td>
  </tr>

  <tr>
    <td><b>User-Friendly Interface</b></td>
    <td>The system features a clean, organized, and mobile-inspired interface designed to provide a smooth and accessible user experience for all users.</td>
  </tr>

</table>
<div align="left">
  <hr style="height:3px;border:none;background-color:#6b21a8;">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/f1ad17b22eaf4b9e54e15f0de307b23bb10963de/Images/How%20it%20Works.png" width="400"/>

<p>
iPocket is a client-server financial application that simulates a real-world e-wallet system with integrated savings and growth features. It enables users to manage their wallet, send and receive money, create savings jars, track financial growth through progressive interest, and securely manage accounts using authentication and KYC verification.
</p>

</div>

<hr>

<div align="center">

<h3>System Architecture</h3>

<pre>
WinForms UI (Frontend)
        ↓
ASP.NET Core Web API (Backend)
        ↓
Service Layer (Business Logic)
        ↓
Entity Framework Core
        ↓
SQLite Database

</pre>
</div>
</div>

<!-- TECH STACK -->
<div align="center">
<div class="section">
<h3>Tech Stack</h3>

<table>
<tr>
    <th>Frontend</th>
    <td>C# WinForms</td>
</tr>
<tr> <div align="center">
    <th>Backend</th>
    <td>ASP.NET Core Web API (.NET 8/10), JWT Authentication</td>
</tr>
<tr>
    <th>Database</th>
    <td>SQLite with Entity Framework Core</td>
</tr>
</table>
</div>
  
<div align="center">

<h3>Application Modules & Savings Interest System</h3>

<table style="width:100%; border-collapse:collapse;">

<tr>

<!-- LEFT TABLE: APPLICATION MODULES -->
<td style="width:65%; vertical-align:top; padding-right:10px;">

<table style="width:100%; border-collapse:collapse;">

<tr><th>Application Modules</th><th>Details</th></tr>

<tr>
    <td><b>Authentication System</b></td>
    <td>User registration and login | OTP verification | JWT session handling</td>
</tr>

<tr>
    <td><b>Wallet System</b></td>
    <td>Deposit money | Send and receive funds | Balance tracking | Transaction history</td>
</tr>

<tr>
    <td><b>Savings System (Jar of Joy)</b></td>
    <td>Create savings jars | Add contributions | Track savings progress | Progressive interest growth</td>
</tr>

<tr>
    <td><b>KYC Verification</b></td>
    <td>ID submission | Status tracking (Pending, Approved, Rejected)</td>
</tr>

<tr>
    <td><b>Dashboard</b></td>
    <td>Wallet overview | Recent transactions | Quick actions</td>
</tr>

</table>

</td>

<!-- RIGHT TABLE: INTEREST SYSTEM -->
<td style="width:35%; vertical-align:top; padding-left:10px;">

<table style="width:100%; border-collapse:collapse;">

<tr><th colspan="2">Savings Interest System</th></tr>

<tr><th>Year</th><th>Rate</th></tr>
<tr><td>1</td><td>3%</td></tr>
<tr><td>2</td><td>4%</td></tr>
<tr><td>3</td><td>5%</td></tr>
<tr><td>4</td><td>6%</td></tr>
<tr><td>5</td><td>7%</td></tr>

</table>

</td>

</tr>

</table>

</div>

<div align="center">

<table>

<tr>

<!-- SYSTEM WORKFLOW -->
<td valign="top" width="33%">

<h2 align="center">System Workflow</h2>

<table>
<tr>
<th>Step</th>
<th>Description</th>
</tr>

<tr><td>1</td><td>User opens WinForms application</td></tr>
<tr><td>2</td><td>User logs in or registers</td></tr>
<tr><td>3</td><td>API validates credentials</td></tr>
<tr><td>4</td><td>JWT token is generated</td></tr>
<tr><td>5</td><td>User accesses dashboard</td></tr>
<tr><td>6</td><td>User performs wallet actions</td></tr>
<tr><td>7</td><td>API processes and stores data</td></tr>
<tr><td>8</td><td>UI updates in real time</td></tr>

</table>

</td>

<!-- DATABASE -->
<td valign="top" width="33%">

<h2 align="center">Database</h2>

<table>
<tr><th>Info</th><th>Details</th></tr>

<tr><td><b>File</b></td><td>iPocket.db</td></tr>
<tr><td><b>Technology</b></td><td>Entity Framework Core</td></tr>

<tr>
<td><b>Stored Data</b></td>
<td>
Users<br>
Wallets<br>
Transactions<br>
Savings Jars<br>
KYC Records
</td>
</tr>

</table>

</td>

<!-- API ENDPOINTS (FIXED - SINGLE TABLE ONLY) -->
<td valign="top" width="33%">

<h2 align="center">API Endpoints</h2>

<table>
<tr>
<th>Base URL</th>
<td>http://localhost:5000</td>
</tr>

<tr>
<th>Swagger</th>
<td>http://localhost:5000/swagger</td>
</tr>

<tr>
<th>Endpoints</th>
<td>
/api/auth/login<br>
/api/auth/register<br>
/api/wallet<br>
/api/wallet/deposit<br>
/api/wallet/send<br>
/api/savings<br>
/api/kyc
</td>
</tr>

</table>

</td>

</tr>

</table>

</div>
<br>
<hr style="height:3px;border:none;background-color:#6b21a8;">
<div align="left">
<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/dae95e5f1fcbe9dcd3f7295fdce79aaf562634c1/Images/Application%20Startup.png" alt="Application Startup" width="500">

<section style="font-family: 'Segoe UI', Arial, sans-serif; max-width: 900px; margin: auto; color: #333;">
    <h2 style="border-bottom: 2px solid #3498db; padding-bottom: 10px; color: #2c3e50;">📂 Project Structure</h2>
    <p>The <strong>iPocket</strong> solution is built using a decoupled Client-Server architecture. This ensures a clear separation between the desktop user interface and the backend business logic.</p>

``` 
iPocket/ (Solution)
├── 📂 iPocket.Winforms/                # Frontend Desktop Application
│   ├── 📂 Properties/                  # App manifest and assembly information
│   ├── 📂 Resources/                   # UI assets (Icons, images, branding)
│   ├── 📄 Form1.cs ... Form3.cs        # Initial landing and startup screens
│   ├── 📄 Form4.cs                     # Login Screen
│   ├── 📄 Form5.cs                     # Mobile Number Entry
│   ├── 📄 Form6.cs                     # OTP Verification (Designer & Resx)
│   ├── 📄 Form7.cs ... Form8.cs        # Account Registration
│   ├── 📄 Form9.cs ... Form10.cs       # KYC / Identity Verification
│   ├── 📄 Form910.cs                   # Post-KYC / Status Screen
│   ├── 📄 Form911.cs                   # Main Dashboard (Home)
│   ├── 📄 Form912.cs                   # Savings Jars Overview
│   ├── 📄 Form913.cs                   # Deposit / Cash-in
│   ├── 📄 Form914.cs                   # Send Money / Transfer
│   ├── 📄 Form915.cs ... Form916.cs    # Savings Details & Growth Projection
│   ├── 📄 Form917.cs                   # User Profile & Account Info
│   ├── 📄 Form918.cs ... Form920.cs    # History and Settings
│   ├── 📄 FormNavigator.cs             # Navigation Logic (Form switching)
│   ├── 📄 Gradient Panel.cs            # Custom UI Component for styling
│   ├── 📄 UserSession.cs               # Local state (JWT Token storage)
│   └── 📄 Program.cs                   # WinForms Application Entry Point
│
└── 📂 iPocket.API/                     # Backend Server & Database Logic
    ├── 📂 Controllers/                 # REST API Endpoints
    ├── 📂 Data/                        # AppDbContext (EF Core Connection)
    ├── 📂 DTOs/                        # Request/Response Data Models
    ├── 📂 Middleware/                  # JWT Auth & Error Handling logic
    ├── 📂 Migrations/                  # EF Core Database Schema History
    ├── 📂 Models/                      # Database Entities (User, Wallet)
    ├── 📂 Services/                    # Core Business & Financial Logic
    ├── ⚙️ appsettings.json             # API Configuration
    ├── 🗄️ iPocket.db                   # SQLite Database File
    └── 📄 Program.cs                   # API Startup & Swagger Configuration
``` 
</span></pre>
    </div>

 <h3 style="color: #2c3e50;">🛠️ Component Responsibilities</h3>
    <table style="width: 100%; border-collapse: collapse; margin-top: 10px; font-size: 14px;">
        <thead>
            <tr style="background-color: #570073; color: white;">
                <th style="padding: 12px; text-align: left; border: 1px solid #dee2e6;">Layer</th>
                <th style="padding: 12px; text-align: left; border: 1px solid #dee2e6;">Technology</th>
                <th style="padding: 12px; text-align: left; border: 1px solid #dee2e6;">Responsibility</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style="padding: 10px; border: 1px solid #dee2e6; font-weight: bold;">Frontend</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">C# WinForms</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">Handles UI/UX, user input, and communicates with the API via HTTP.</td>
            </tr>
            <tr style="background-color: #f9f9f9;">
                <td style="padding: 10px; border: 1px solid #dee2e6; font-weight: bold;">Backend</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">ASP.NET Core Web API</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">Processes business logic, secures endpoints with JWT, and manages the database.</td>
            </tr>
            <tr>
                <td style="padding: 10px; border: 1px solid #dee2e6; font-weight: bold;">Database</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">SQLite / EF Core</td>
                <td style="padding: 10px; border: 1px solid #dee2e6;">Persists user data, wallet balances, and transaction logs in a local file.</td>
            </tr>
        </tbody>
    </table>
</section>

<hr style="height:3px;border:none;background-color:#6b21a8;">
<div align="center">

<img src="https://github.com/sushiGyuuuuu/iPocket-Final/blob/77e3b9c2b28afe9f3980d11e0767371c54f0373d/Images/Team%20Members.png" width="700"/>

</div>


 <table>
  <tr>
    <th>Name</th>
    <th>Role</th>
    <th>Quick Responsibilities</th>
    <th>GitHub</th>
  </tr>

  <tr>
    <td>Orquinaza, Marylein L.</td>
    <td>UI/UX Designer</td>
    <td>Conceptualized the project idea and designs UI/UX with wireframes and user flow.</td>
    <td><a href="https://github.com/yamahoera" target="_blank">yamahoera</a></td>
  </tr>

  <tr>
    <td>Perez, Gabriel Theodore D.</td>
    <td>Backend Developer & UI/UX Designer</td>
    <td>Develops backend logic and assists in UI/UX design and system structure.</td>
    <td><a href="https://github.com/sushiGyuuuuu" target="_blank">sushiGyuuuuu</a></td>
  </tr>

  <tr>
    <td>Velasco, Iah Shanelle E.</td>
    <td>WinForms Developer</td>
    <td>Implements WinForms interface and integrates application features.</td>
    <td><a href="https://github.com/macherieshanelle" target="_blank">macherieshanelle</a></td>
  </tr>

</table>

</body>
</html>
