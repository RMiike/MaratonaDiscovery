import axios from "axios";

const api = axios.create({
  baseURL: "https://localhost:44396/v1/",
});

export default api;
