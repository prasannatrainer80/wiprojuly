import axios from "axios";
import AuthHeader from "./AuthHeader";

const ProtectedService = () => {
 const adminDashBoard = async () => {
    try {
        const response = await axios.get("https://localhost:7135/api/Protected", {
            headers: AuthHeader()
        });
        return response;
    } catch (error) {
        console.error("Admin Authentication failed", error);
        throw error;
    }
    };
    return {
        adminDashBoard
    }
}

export default ProtectedService;