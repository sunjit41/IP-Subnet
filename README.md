## 🛑 Usage & Licensing Notice
This repository is **source-available for educational purposes only**. 

* **What you CAN do:** Feel free to clone this repository, run it locally, explore the architecture, and use it to learn or evaluate my coding style.
* **What you CANNOT do:** You are strictly prohibited from re-distributing, republishing, or commercializing this software or its source code anywhere else. 

# IP Subnet (Classfull) Calculator

A robust Windows Forms application built with **C#** and **.NET** for calculating IPv4 Classful Subnetting. This tool simplifies networking tasks by instantly determining IP classes, subnets, hosts, binary values, and CIDR masks, along with generating exportable HTML subnetting reports.

---

## 🚀 Features

* **IP Address Section:** Automatically detects IP Class (A, B, or C), network type (Public vs. Private), and provides real-time binary conversions for each octet.
* **Dynamic Subnet Masking:** Visual slider and dropdown selections for CIDR notation (`/24` to `/30`), updating the subnet mask dynamically.
* **Sub Network Breakdown:** 
  * Calculates **Subnet bits** and **Host bits**.
  * Displays total available **Subnets** and **Hosts per subnet**.
  * Shows explicit binary breakdown of the masking bits (`11111111 ... 1111[0000]`).
* **HTML Export:** Export full, well-structured subnet sheets to HTML reports with a single click.

---

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET 
* **UI Technology:** Windows Forms (WinForms)

---

## 💻 Getting Started

### Prerequisites
* [Visual Studio](https://visualstudio.microsoft.com/) (2022 or newer recommended)
* .NET Framework SDK / .NET SDK installed

### Installation & Running
1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Build and Run the project (`F5`).

---

## 📊 Usage Guide

1. **Enter IP Address:** Input your desired IP address into the designated text fields.
2. **Select Subnet Mask:** Use the slider or dropdown (`/28`, etc.) to define your subnet requirements.
3. **Analyze:** View instant calculations for subnets, available hosts, and bit allocations.
4. **Generate Report:** Click on **Show Sub Networks** to inspect the networks and export your structured HTML report.

---


