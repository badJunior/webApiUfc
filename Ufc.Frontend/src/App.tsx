import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import UfcList from "./UfcList";

const queryClient = new QueryClient();

function App() {
  return (
    <QueryClientProvider client={queryClient}>
      <UfcList />
    </QueryClientProvider>
  );
}

export default App;
