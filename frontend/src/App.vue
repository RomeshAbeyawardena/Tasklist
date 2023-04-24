<script setup lang="ts">
  import dayEntry from './components/day-entry.vue';
  import { Entry } from './models/entry';
  import { ref } from "vue";
  const entry = ref(new Entry());
</script>

<template>
  <dayEntry :entry="entry" />
  <dayEntry :entry="entry" />
</template>
