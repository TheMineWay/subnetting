<script lang="ts">
import { Options, Vue } from "vue-class-component";
import Layout from "./views/layout/Layout.vue";
import './App.css';

@Options({
  components: {
    Layout,
  }
})
export default class App extends Vue { }

</script>

<template>
  <Layout />
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
}
</style>
