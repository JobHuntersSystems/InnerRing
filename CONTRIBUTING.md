# Contributing

## Branching strategy

We use the following branch model:

- `main`: stable production-ready branch
- `dev`: integration branch
- `feature/*`: new features
- `bugfix/*`: bug fixes
- `hotfix/*`: urgent fixes for production

## Workflow

### Feature development
1. Create a branch from `dev`
   - Example: `feature/planet-rsa-generation`
2. Develop and commit your changes
3. Open a Pull Request to `dev`
4. Wait for CI to pass
5. Get at least 1 approval
6. Merge using **Squash and merge**

### Release to main
1. Open a Pull Request from `dev` to `main`
2. Ensure all checks pass
3. Get at least 2 approvals
4. Merge using **Squash and merge**

### Hotfixes
1. Create a branch from `main`
   - Example: `hotfix/fix-vk-message-parse`
2. Open a Pull Request to `main`
3. After merge, sync changes back into `dev`

## Pull Request rules

- PR title must clearly describe the change
- PR should be small and focused
- Link the related issue
- Do not mix refactor + feature + bugfix in the same PR
- Resolve all review conversations before merge

## Commit message guideline

Recommended format:

- `feat: add RSA public key export`
- `fix: validate ER message length`
- `refactor: extract tcp message parser`
- `test: add validation code generator tests`

## Project structure

Current repository layout:

```text
./
  PACS-Planets/
    solucion.sln
    App/
  PACS-Spaceship/
    solucion.sln
    App/