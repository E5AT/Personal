# Supabase Auth Starter

A modern authentication starter template built with React, Vite, Tailwind CSS, and Supabase. Demonstrates secure authentication flows including signup, login, and protected routes.

![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![Vite](https://img.shields.io/badge/Vite-B73BFE?style=for-the-badge&logo=vite&logoColor=FFD62E)
![Supabase](https://img.shields.io/badge/Supabase-3FCF8E?style=for-the-badge&logo=supabase&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind_CSS-38B2AC?style=for-the-badge&logo=tailwind-css&logoColor=white)

## Features

- 🛡️ Secure authentication using Supabase
- 🔐 Protected routes with React Router
- 📱 Responsive design with Tailwind CSS
- 🔄 Real-time session management
- 🧩 Modular component architecture
- 🧪 ESLint configuration with React best practices

## Prerequisites

- Node.js >= 18.x
- npm >= 9.x
- Supabase account (free tier available)

## Installation

1. Clone the repository:
```bash
git clone [repository-url]
```

2. Navigate to project directory:
```bash
cd SUPABASE-AUTH
```

3. Install dependencies:
```bash
npm install
```

## Configuration

1. Create a `.env` file in the project root:
```env
VITE_SUPABASE_URL=your-supabase-url
VITE_SUPABASE_ANON_KEY=your-supabase-anon-key
```

2. Get your Supabase credentials:
- Go to your [Supabase Dashboard](https://app.supabase.com/)
- Create new project
- Navigate to Project Settings > API
- Copy URL and anon public key

## Running the Project

```bash
npm run dev
```

## Project Structure

```bash
├── src/
│   ├── components/      # Reusable UI components
│   │   ├── Dashboard.jsx
│   │   ├── PrivateRoute.jsx
│   │   ├── Signin.jsx
│   │   └── Signup.jsx
│   │
│   ├── context/         # Authentication context
│   │   └── AuthContext.jsx
│   │
│   ├── router.jsx       # Application routes
│   ├── supabaseClient.js # Supabase initialization
│   └── ...
├── vite.config.js       # Vite + Tailwind configuration
└── ...
```

## Environment Variables

| Variable              | Description                        |
|-----------------------|------------------------------------|
| VITE_SUPABASE_URL     | Your Supabase project URL          |
| VITE_SUPABASE_ANON_KEY| Your Supabase anonymous API key    |

## Demo Video Reference

The implementation follows the structure shown in this tutorial video:
[SUPABASE-AUTH Tutorial](https://youtu.be/1KBV8M0mpYI?si=JlQqprVYkNlsNfDo)
