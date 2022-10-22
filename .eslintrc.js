module.exports = {
  root: true,
  env: {
    node: true,
  },
  extends: [
    "plugin:vue/vue3-essential",
    "@vue/typescript/recommended",
    "eslint:recommended",
    /*"plugin:prettier/recommended",*/
  ],
  parserOptions: {
    ecmaVersion: 2020,
  },
};
