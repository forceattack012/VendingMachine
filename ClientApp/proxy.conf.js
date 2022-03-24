const { env } = require('process');

const target = 'http://localhost:5295';

const PROXY_CONFIG = [
  {
    context: [
      "/api",
   ],
    target: target,
    secure: false
  }
]

module.exports = PROXY_CONFIG;
