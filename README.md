# 🎓 School Management System

> A console-based school management application built with C# and .NET for managing students and teachers through a structured service-based architecture.

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [Architecture](#-architecture)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Application Flow](#-application-flow)
- [Author](#-author)
- [License](#-license)

---

## 📖 Overview

**School Management System** is a modular console application developed with **C# and .NET**.

The system provides a centralized environment for managing core school data, including:

- Students
- Teachers

The application is designed around a **service-based structure**, where business logic is separated from the console interface and domain models.

The project demonstrates practical usage of **Object-Oriented Programming, interfaces, collections, LINQ, CRUD operations, searching, sorting, and pagination**.

---

## ✨ Features

### 👨‍🎓 Student Management

- Create students
- View all students
- Search students by name
- Get student count
- Add multiple students
- Update student information
- Delete students by ID
- Paginate student records
- Sort students by name

### 👨‍🏫 Teacher Management

- Create teachers
- View all teachers
- Find teachers by ID
- Update teacher information
- Delete teachers by ID
- Display teacher information

### ⚙️ General

- Interactive console menus
- Service-based business logic
- Interface-driven services
- LINQ-based data processing
- In-memory collection management
- ID-based record operations

---

## 🛠️ Technology Stack

| Technology | Usage |
|---|---|
| **C#** | Application development |
| **.NET** | Runtime and application platform |
| **LINQ** | Searching, filtering, sorting, pagination and counting |
| **List<T>** | In-memory collection management |
| **Array** | Collection and multiple-record operations |
| **Interfaces** | Service abstraction |
| **OOP** | Application architecture and design |
| **Git** | Version control |
| **GitHub** | Source code management |

---

## 🏗️ Architecture

The application follows a simple **Service Layer Architecture**.

```text
                    School Management System
                              │
                ┌─────────────┴─────────────┐
                │                           │
          Student Module              Teacher Module
                │                           │
        ┌───────┴───────┐           ┌───────┴───────┐
        │               │           │               │
    Interface        Service    Interface        Service
        │               │           │               │
        └───────────────┘           └───────────────┘
                │                           │
                └─────────────┬─────────────┘
                              │
                         Program.cs
                              │
                       Console Interface