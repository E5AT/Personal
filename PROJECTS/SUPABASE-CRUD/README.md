# SUPABASE-CRUD - React CRUD App with Supabase

![Supabase](https://img.shields.io/badge/Supabase-3ECF8E?style=for-the-badge&logo=supabase&logoColor=white)
![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)
![Vite](https://img.shields.io/badge/Vite-B73BFE?style=for-the-badge&logo=vite&logoColor=FFD62E)

A React application demonstrating basic CRUD (Create, Read, Update, Delete) operations using Supabase as the backend service.

## Features

- Create new records
- Read and display data from Supabase
- Update existing records
- Delete records
- Real-time updates
- Secure authentication via Supabase

## Prerequisites

- Node.js >= 18.x
- npm >= 9.x
- Supabase account

## Installation

```bash
git clone [repository-url]
cd SUPABASE-CRUD
npm install
```

## Configuration

1. Create `.env` file in project root:
```ini
VITE_SUPABASE_URL=your_supabase_url
VITE_SUPABASE_KEY=your_supabase_anon_key
```

2. Get credentials from your Supabase project dashboard

## Available Scripts

```bash
npm run dev    # Start development server
npm run build  # Create production build
npm run lint   # Run ESLint checks
npm run preview # Preview production build
```

## Project Structure

```bash
src/
├── App.jsx          # Main application component
├── main.jsx         # Application entry point
├── supabase-client.js # Supabase initialization
public/              # Static assets
.env                 # Environment variables (template)
```

## Tutorial

Follow along with the video tutorial:  
[Supabase CRUD Tutorial](https://youtu.be/tW1HO7i9EIM?si=aIt4ifSw6z1NErzC)

![App Preview](public/app-preview.png)

## Important Notes

⚠️ **DO NOT COMMIT SECRETS**  
- Add `.env` and `password.txt` to `.gitignore`
- Never expose Supabase credentials in version control

## Contributing

Pull requests welcome! For major changes, please open an issue first.

## License

[MIT](LICENSE)
