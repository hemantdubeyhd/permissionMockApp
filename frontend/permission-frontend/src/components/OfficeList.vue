<script setup>
import {ref, onMounted}  from 'vue';

const offices = ref([]);
const error = ref('');

const fetchOffices = async () =>
{
    try
    {
        const res = await fetch('https://localhost:7047/api/office');
        if(!res.ok) throw new Error('Failed to fetch');
        const data =await res.json();
        offices.value = data;
    }
    catch(err)
    {
        error.value = 'Error fetching offcie list';
        console.error(err);
    }

};
onMounted(() =>
{
    fetchOffices();
});
</script>

<template>
    <div>
        <h2>Office List</h2>
        <div v-if="error" style="color: red;">{{ error }}</div>

        <ul v-else>
            <li v-for="office in offices" :key="office.id">
                {{ office.id  }}- {{ office.name  }}
            </li>
        </ul>
    </div>
</template>

<style scoped>
h2{
    color:  #007acc;
    margin-bottom: 1rem ;
}

ul{
    list-style-type: none;
    padding-left: 0;
}

li{
    margin-bottom: 5px;
}
</style>