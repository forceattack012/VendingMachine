const { env } = require('process');

const target = 'http://localhost:5295';

const PROXY_CONFIG = [
  {
    context: [
      "/api",
      "/adminHub"
   ],
    target: target,
    secure: false,
    "ws": true
  }
]

module.exports = PROXY_CONFIG;
