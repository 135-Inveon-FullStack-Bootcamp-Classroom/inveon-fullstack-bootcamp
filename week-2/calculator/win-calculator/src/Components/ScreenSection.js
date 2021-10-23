const styles = {
  screenSection: {
    width: "100%",
    height: "30%",
    display: "flex",
    justifyContent: "flex-end",
  },
  mainText: {
    color: "#fff",
    fontSize: 30,
    padding: 10,
  },
};

const ScreenSection = () => {
  return (
    <div style={styles.screenSection}>
      <span style={styles.mainText}>5</span>
    </div>
  );
};

export default ScreenSection;
