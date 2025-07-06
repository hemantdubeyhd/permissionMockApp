<script setup>
import {ref, onMount}  from 'vue';

const offices = ref([]);
const error = ref([]);

const fetchOffices = async () =>
{
    try
    {
        const res = await fetch('https://localhost:7047/api/office');
        if(!res.ok) throw new Error('Failed to fecth');
        const data =await res.json();
        offices.value = data;
    }
    catch(err)
    {
        error.value = 'Error fetching offcie list';
        console.error(err);
    }

};
onMount(() =>
{
    fetchOffices();
});
</script>

<template>
    <div>
        <h2>Office List</h2>
        <div v-if="error" style="color: red;">{{ error }}</div>

        <ul v-else>
            <li v-for="office in offices" :key="office.id"></li>
        </ul>
    </div>
</template>