FROM node:18 AS build
WORKDIR /app

# Copy only the package.json and package-lock.json first to leverage Docker caching
COPY my-app/package*.json ./

# Install dependencies
RUN npm install

# Copy the rest of the application code
COPY my-app/. .

# Expose the React development server port
EXPOSE 3000

# Start the development server
CMD ["npm", "start"]
