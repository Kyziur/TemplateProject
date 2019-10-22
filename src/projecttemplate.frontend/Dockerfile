FROM node:lts-alpine

# install simple http server for serving static content
RUN npm install -g http-server

# make the 'app' folder the current working directory
WORKDIR /app/projecttemplate.frontend/
# add `/app/node_modules/.bin` to $PATH
ENV PATH /app/node_modules/.bin:$PATH
# copy both 'package.json' and 'package-lock.json' (if available)
COPY package*.json ./app/projecttemplate.frontend/

# install project dependencies
RUN npm install --silent
RUN npm install react-scripts@3.0.1 -g --silent

VOLUME /app/projecttemplate.frontend

EXPOSE 3000
CMD ["npm", "start"]
