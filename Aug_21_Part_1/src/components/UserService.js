import axios from "axios"

export const getUsers = async () => {
    const response = await axios.get("http://jsonplaceholder.typicode.com/users");
    return response.data;
}

export const getUserById = async (id) => {
    const response = await axios.get("http://jsonplaceholder.typicode.com/users/" +id);
    return response.data;
}