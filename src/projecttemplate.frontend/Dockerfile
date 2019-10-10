FROM node:lts-alpine

# install simple http server for serving static content
RUN npm install -g http-server

# make the 'app' folder the current working directory
WORKDIR /app/projecttemplate.frontend/
# add `/app/node_modules/.bin` to $PATH
ENV PATH /app/node_modules/.bin:$PATH
# copy both 'package.json' and 'package-lock.json' (if available)
COPY package*.json ./

# install project dependencies
RUN npm install
RUN npm install @vue/cli@3.7.0 -g

VOLUME /app/projecttemplate.frontend

EXPOSE 8080
CMD ["npm", "run", "serve"]
