<!--
<script setup>
import { ref } from 'vue'

defineProps({
  msg: String,
})

const count = ref(0)
</script>

<template>
  <h1>{{ msg }}</h1>

  <div class="card">
    <button type="button" @click="count++">count is {{ count }}</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>
    Learn more about IDE Support for Vue in the
    <a
      href="https://vuejs.org/guide/scaling-up/tooling.html#ide-support"
      target="_blank"
      >Vue Docs Scaling up Guide</a
    >.
  </p>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped>
.read-the-docs {
  color: #888;
}
</style>-->

<script setup>
import {ref, onMounted} from 'vue';

const message = ref('Loading...');

onMounted(async() =>
{
  try
  {
    const res = await fetch('https://localhost:7047/api/test/hello');
    const data = await res.json();
    message.value = data.message;
  }
  catch(error)
  {
  message.value = 'Error fetching from backend';
}
});
</script>

<template>
  <div>
    <h1> {{ message }}</h1>
  </div>
</template>